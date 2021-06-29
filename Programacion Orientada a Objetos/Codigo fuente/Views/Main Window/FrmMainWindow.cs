using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient.Server;
using VaccinationManagement.Context;
using VaccinationManagement.Models;
using VaccinationManagement.Views;
using System.Runtime.InteropServices;
using VaccinationManagement.Controls;
using VaccinationManagement.Views.Main_Window;

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
            
            lblUser.Text = LocationData.GestorName;
            
            FormHija(new FrmGraphics());

        }
        
        private void picLogoGobierno_Click(object sender, EventArgs e)
        {
              FormHija(new FrmGraphics());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Se asignó al boton 
            
            FormHija(new AppointmentProcess());
            //var appointmentProcess = new AppointmentProcess();
                       
            // Abrir un formulario para registrar los datos del ciudadano 
            //Hide();
            //appointmentProcess.ShowDialog();
            //Show();
        }
        
        private void btnRegister_Click2(object sender, EventArgs e)
                {
                    //Se asignó al boton 
                    
                    FormHija(new AppointmentProcess(fh2.vf));
                    //var appointmentProcess = new AppointmentProcess();
                               
                    // Abrir un formulario para registrar los datos del ciudadano 
                    //Hide();
                    //appointmentProcess.ShowDialog();
                    //Show();
                }
        
        private void btnVerificationCita_Click(object sender, EventArgs e)
        {
          
          FormHija2(new Frmverification());
          fh2.btnVerification.Click += btnRegister_Click2;



        }
        
        private void UpdateDataView_Click2(object sender, EventArgs e)
        {
            //Se asignó al boton 
            //var vaccinationProcessLogin = new FrmGetDui();
            FormHija(new VaccinationProcess(fh3.vf));
            
            // Abrir un formulario para verificar el Dui 
            //Hide();
            //vaccinationProcessLogin.ShowDialog();
            //Show();
        }

        private void UpdateDataView_Click(object sender, EventArgs e)
        {
           //Se asignó al boton 
           //var vaccinationProcessLogin = new FrmGetDui();
           FormHija3(new FrmGetDui());
           fh3.btnVerification.Click += UpdateDataView_Click2;
           // Abrir un formulario para verificar el Dui 
           //Hide();
           //vaccinationProcessLogin.ShowDialog();
           //Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            using (var LogOut = new FrmLogOut())
            {
                var result = LogOut.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    Hide();
                    FrmCloseMainWindow close = new FrmCloseMainWindow();
                    close.ShowDialog();
                }
                                        
            }
            
        }
        
        private void picClose_Click(object sender, EventArgs e)
        {
            using (var cancel = new FrmClose())
            {
                var result = cancel.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                                        
            }
            
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

        

        private Form fh;
          private void  FormHija(object formhija)
          {
                if (this.pnlPrincipal.Controls.Count > 0)
                    this.pnlPrincipal.Controls.RemoveAt(0);
                fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pnlPrincipal.Controls.Add(fh);
                this.pnlPrincipal.Tag = fh;
                fh.Show();
          }
          private Frmverification fh2;
          private void  FormHija2(Frmverification formhija2)
          {
             if (this.pnlPrincipal.Controls.Count > 0)
             this.pnlPrincipal.Controls.RemoveAt(0);
             fh2 = formhija2;
             fh2.TopLevel = false;
             fh2.Dock = DockStyle.Fill;
             this.pnlPrincipal.Controls.Add(fh2);
             this.pnlPrincipal.Tag = fh2;
             fh2.Show();
          }
          
          private FrmGetDui fh3;
          
          private void  FormHija3(FrmGetDui formhija3)
          {
            if (this.pnlPrincipal.Controls.Count > 0)
            this.pnlPrincipal.Controls.RemoveAt(0);
            fh3 = formhija3;
            fh3.TopLevel = false;
            fh3.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(fh3);
            this.pnlPrincipal.Tag = fh3;
            fh3.Show();
          }


          
    }
}