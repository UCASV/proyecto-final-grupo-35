using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D; 
using VaccinationManagement.Context;
using VaccinationManagement.Models;
using VaccinationManagement.Views;
using System.Runtime.InteropServices;

namespace VaccinationManagement.View
{
    public partial class Login : Form
    {
        private List<User> loginData;
        public Login()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();

            try
            {
                loginData = db.Users.Where(w =>
                    w.Users == txtUser.Text && w.PasswordUser == txtPassword.Text).ToList();
                var actualEmployee = db.Employees.Where(E => E.IdUser == loginData.First().Id).ToList().First();
                LocationData.UserId = loginData.First().Id;
                LocationData.GestorName = actualEmployee.EmployeeName;
                LocationData.IdActualBooth = actualEmployee.IdBooth;
                LocationData.GestorId = actualEmployee.Id;
                
                if (loginData.Count != 0)
                {
                    btnInsert_LogIn();
                    this.Hide();
                    frmWelcomeUser welcome = new frmWelcomeUser();
                    welcome.ShowDialog();
                    
                    using (var mainWindow = new FrmMainWindow(loginData.First()))
                    {
                        Hide();
                        mainWindow.ShowDialog();
                        Show();
                    }
                }
                else
                {
                    MessageBox.Show("Datos no validos");
                }
            }
            catch (InvalidOperationException exception)
            {
                using (var cancel = new FrmInvalidData())
                {
                    var result = cancel.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                                        
                }

            }
            
        }
        

        private void chkShowPasseword_Click(object sender, EventArgs e)
        {
            if (chkShowPasseword.Checked == true)
            {
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                }
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnInsert_LogIn()
        {
            
            var db = new VaccinationContext();

            var DataEmployee = db.Employees.Where(w =>
                w.IdUser == loginData.First().Id).ToList().First();

            var RegisterLogin = new LogIn()
            {
                IdUser = loginData.First().Id,
                IdBooth = DataEmployee.IdBooth,
                DateTime = DateTime.Now

            };
                db.LogIns.Add(RegisterLogin);
                db.SaveChanges();
        }


        private void picCloseForm_Click(object sender, EventArgs e)
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

        private void picMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}