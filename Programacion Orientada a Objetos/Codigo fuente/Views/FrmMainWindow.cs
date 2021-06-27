using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient.Server;
using VaccinationManagement.Context;
using VaccinationManagement.Models;
using VaccinationManagement.Views;
using System.Runtime.InteropServices;

namespace VaccinationManagement.View
{
    public partial class FrmMainWindow : Form
    {
        public User userData { get; set; }

        public FrmMainWindow(User userData)
        {
            var db = new VaccinationContext();
            this.userData = userData;
            
            InitializeComponent();
            
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Se asignó al boton 
            var appointmentProcess = new AppointmentProcess();
                       
            // Abrir un formulario para registrar los datos del ciudadano 
            Hide();
            appointmentProcess.ShowDialog();
            Show();
        }
        
        
        private void btnVerificationCita_Click(object sender, EventArgs e)
        {
          
        }

        private void UpdateDataView_Click(object sender, EventArgs e)
        {
           //Se asignó al boton 
           var vaccinationProcessLogin = new FrmGetDui();
                   
           // Abrir un formulario para verificar el Dui 
           Hide();
           vaccinationProcessLogin.ShowDialog();
           Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea salir del sistema?",
                "Consulta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
        
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tmrHour_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}