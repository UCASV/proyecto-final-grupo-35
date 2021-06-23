using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VaccinationManagement.Context;
using VaccinationManagement.Models;

namespace VaccinationManagement.View
{
    public partial class Login : Form
    {
        private List<User> loginData;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();

            try
            {
                loginData = db.Users.Where(w =>
                    w.Users == txtUser.Text && w.PasswordUser == txtPassword.Text).ToList();
                
                if (loginData.Count != 0)
                {
                    button1_Click2();
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
                MessageBox.Show("Error: Introduce datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void button1_Click2()
        {
            
            var db = new VaccinationContext();

            var DataEmployee = db.Employees.Where(w =>
                w.IdUser == loginData.First().Id).ToList().First();

            var RegisterLogin = new LogIn()
            {
                IdUser = loginData.First().Id,
                IdBooth = DataEmployee.IdBooth,
                //IdUserNavigation = loginData.ToList().First(),
                //IdBoothNavigation = db.Booths.Where(w=> w.Id == DataEmployee.IdBooth).ToList().First(),
                DateTime = DateTime.Now

            };
                db.LogIns.Add(RegisterLogin);
                db.SaveChanges();
        }
        
        
    }
}