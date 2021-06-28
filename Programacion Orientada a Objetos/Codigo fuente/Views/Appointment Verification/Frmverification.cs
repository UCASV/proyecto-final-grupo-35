using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VaccinationManagement.Context;
using VaccinationManagement.Models;
using System.Runtime.InteropServices;

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
                using (var invalid = new FrmInvalidData())
                {
                    var result = invalid.ShowDialog();
                    if (result == DialogResult.OK) ;
                    
                }
            }
            
            try
            {
                var citizen = (from B in db.Booths
                    join E in db.Employees on B equals E.IdBoothNavigation
                    join C in db.Citizens on E equals C.IdEmployeeNavigation
                    join A in db.Appointments on C equals A.IdCitizenNavigation
                    where B.Id == LocationData.IdActualBooth && C.Dui == Int32.Parse(textBox1.Text)
                    select C).ToList().First();


                using (var citeFound = new FrmCitationFound())
                {
                    var result = citeFound.ShowDialog();
                    if (result == DialogResult.OK) ;
                    
                }

                var appointmentProcess = new AppointmentProcess(citizen);
                
                Hide();
                appointmentProcess.ShowDialog();
                Close();
            }
            catch (InvalidOperationException exception)
            {
                var cita = new FrmCitesInTheFound();

                var result = cita.ShowDialog();
                if(result == DialogResult.OK)
                

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
                using (var invalid = new FrmInvalidData())
                {
                    var result = invalid.ShowDialog();
                    if (result == DialogResult.OK) ;
                    
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (var cancel = new FrmClose())
            {
                var result = cancel.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                                                    
            }
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Frmverification_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}