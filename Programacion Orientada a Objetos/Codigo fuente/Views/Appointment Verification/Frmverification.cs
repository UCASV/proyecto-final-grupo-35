using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VaccinationManagement.Context;
using VaccinationManagement.Models;

namespace VaccinationManagement.Views
{
    public partial class Frmverification : Form
    {
        public Frmverification()
        {
            InitializeComponent();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();

            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un numero de Dui", "ERROR");
                return;
            }
            
            try
            {
                var citizen = (from B in db.Booths
                    join E in db.Employees on B equals E.IdBoothNavigation
                    join C in db.Citizens on E equals C.IdEmployeeNavigation
                    join A in db.Appointments on C equals A.IdCitizenNavigation
                    where B.Id == LocationData.IdActualBooth && C.Dui == Int32.Parse(textBox1.Text)
                    select C).ToList().First();


                MessageBox.Show($"Este numero de Dui fue encontrado para este local, a continuacion se verificaran sus datos: ",
                    "Encontrado", MessageBoxButtons.OK);

                var appointmentProcess = new AppointmentProcess(citizen);
                
                Hide();
                appointmentProcess.ShowDialog();
                Close();
            }
            catch (InvalidOperationException exception)
            {
                var result = MessageBox.Show($"No hay datos registrados para este numero de Dui, ¿Desea registrarlo?",
                    "Cita no encontrada", MessageBoxButtons.OKCancel);

                using (var appointmentProcess = new AppointmentProcess())
                {
                    if (result == DialogResult.OK)
                    {
                        Hide();
                        appointmentProcess.ShowDialog();
                        Close();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Porfavor revise los datos ingresados", "Error", MessageBoxButtons.OK);
            }
        }
        
    }
}