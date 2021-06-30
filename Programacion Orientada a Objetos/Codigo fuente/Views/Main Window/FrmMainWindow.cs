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
            
            ChangeChildrenFrm(new FrmGraphics());

        }
        
        private void picLogoGobierno_Click(object sender, EventArgs e)
        {
              ChangeChildrenFrm(new FrmGraphics());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Se asignó al boton    
            ChangeChildrenFrm(new AppointmentProcess());
        }
        private void childrenFormClose(object sender, EventArgs e)
        {
            ChangeChildrenFrm(new FrmGraphics());

        }
        
        private void btnVerificationFrm_Click(object sender, EventArgs e)
        {
            //Se asignó al boton
            ChangeChildrenFrm(new AppointmentProcess(FrmVerificationChildren.CitizenToChange));
        }

        
        private void btnVerificationCita_Click(object sender, EventArgs e)
        {
          
          ChangeToFrmVefication(new Frmverification());
          FrmVerificationChildren.btnVerification.Click += btnVerificationFrm_Click;
          FrmVerificationChildren.btnVerificationPrint.Click += btnVerificationFrm_Click;
          
        }
        
        private void FrmverificationChangeDataEvent(object sender, EventArgs e)
        {
            //Se asignó al boton 
            ChangeChildrenFrm(new VaccinationProcess(FrmGetDuiToDisplay.appointmentoToDisplay));
            
        }

        private void UpdateDataView_Click(object sender, EventArgs e)
        {
           //Se asignó al boton 
           ChangeToFrmGetDui(new FrmGetDui());
           FrmGetDuiToDisplay.btnVerification.Click += FrmverificationChangeDataEvent;

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
        
        private Form ChildrenToDisplay;
          private void  ChangeChildrenFrm(object ChangeChildrenFrm)
          {
                if (this.pnlPrincipal.Controls.Count > 0)
                    this.pnlPrincipal.Controls.RemoveAt(0);
                ChildrenToDisplay = ChangeChildrenFrm as Form;
                ChildrenToDisplay.TopLevel = false;
                ChildrenToDisplay.Dock = DockStyle.Fill;
                this.pnlPrincipal.Controls.Add(ChildrenToDisplay);
                this.pnlPrincipal.Tag = ChildrenToDisplay;
                ChildrenToDisplay.Show();

                ChildrenToDisplay.FormClosed += childrenFormClose; 
          }
          private Frmverification FrmVerificationChildren;
          private void  ChangeToFrmVefication(Frmverification ChangeToFrmVefication)
          {
             if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);
             FrmVerificationChildren = ChangeToFrmVefication;
             FrmVerificationChildren.TopLevel = false;
             FrmVerificationChildren.Dock = DockStyle.Fill;
             this.pnlPrincipal.Controls.Add(FrmVerificationChildren);
             this.pnlPrincipal.Tag = FrmVerificationChildren;
             FrmVerificationChildren.Show();

             FrmVerificationChildren.FormClosed += childrenFormClose; 

          }
          
          private FrmGetDui FrmGetDuiToDisplay;
          
          private void ChangeToFrmGetDui(FrmGetDui ChangeToFrmGetDui)
          {
            if (this.pnlPrincipal.Controls.Count > 0)
            this.pnlPrincipal.Controls.RemoveAt(0);
            FrmGetDuiToDisplay = ChangeToFrmGetDui;
            FrmGetDuiToDisplay.TopLevel = false;
            FrmGetDuiToDisplay.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(FrmGetDuiToDisplay);
            this.pnlPrincipal.Tag = FrmGetDuiToDisplay;
            FrmGetDuiToDisplay.Show();

            FrmGetDuiToDisplay.FormClosed += childrenFormClose; 

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

        



          
    }
}