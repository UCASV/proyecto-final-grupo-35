using System;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void btnVerification_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var dui = 0;

            ////Primero se verifica que no este vacio le txtBox
            if (txtDui.Text.Equals(""))
            {
                MessageBox.Show("Ingreso un numero de Dui ", "ERROR");
                return;
            }
            
            //Se intenta obtener el dui desde el textBox
            try
            {
                dui = Int32.Parse(txtDui.Text);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Revise los datos ingresados", "ERROR");
                txtDui.Text = "";
            }
            //
            
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (var cancel = new FrmMessageBoxCancel())
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

        private void FrmGetDui_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
