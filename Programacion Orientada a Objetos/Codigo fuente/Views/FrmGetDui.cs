using System;
using System.Linq;
using System.Windows.Forms;
using VaccinationManagement.Context;

namespace VaccinationManagement.Views
{
    public partial class FrmGetDui : Form
    {
        public FrmGetDui()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var dui = 0;
            
            try
            {
                if(!textBox1.Text.Equals("")) 
                    dui = Int32.Parse(textBox1.Text);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Revise los datos ingresados");
                textBox1.Text = "";
            }

            if (!textBox1.Text.Equals(""))
            {
                 //Revisar si hay citas de ese DUI
                var appointments = from B in db.Booths
                    join E in db.Employees on B equals E.IdBoothNavigation
                    join C in db.Citizens on E equals C.IdEmployeeNavigation
                    join A in db.Appointments on C equals A.IdCitizenNavigation
                    where B.Id == LocationData.IdActualBooth && C.Dui == dui

                    select C.Dui;
                
                //Si hay, se abre el siguiente formulario 
                if(appointments.ToList().Count != 0)
                {
                    var vaccinationProcess = new VaccinationProcess(appointments.ToList()[0]);
                    Hide();
                    vaccinationProcess.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("No se encontraron citas para este número de DUI");
                }
            }
        }
    }
}
