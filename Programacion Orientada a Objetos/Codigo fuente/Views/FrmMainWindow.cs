using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient.Server;

using VaccinationManagement.Context;
using VaccinationManagement.Models;
using VaccinationManagement.Views;

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

        public void btnUpdateDataView_click(object sender, EventArgs e)
        {
            using (var vaccinationProcessLogin = new FrmGetDui())
            {
                var db = new VaccinationContext();
                var loop = true;
                
                do
                {
                    var dialogResult = vaccinationProcessLogin.ShowDialog();
                    
                    if (dialogResult == DialogResult.OK)
                    {
                        try
                        {
                            var dui = Int32.Parse(vaccinationProcessLogin.textBox1.Text);
                            var citizenCheck = db.Citizens.Where(w => w.Dui == dui).ToList();
                            if (citizenCheck.Count != 0)
                            {
                                var vaccinationProcess = new VaccinationProcess(dui); 
                                Hide();
                                vaccinationProcess.ShowDialog();
                                Show();
                                loop = false;
                            }
                            else
                            {
                                MessageBox.Show("Dui no encontrado, verifica y vuelve a intentarlo");
                            }
                        }
                        catch (FormatException exception)
                        {
                            MessageBox.Show("Vuelva a digitar el DUI del ciudadano");
                        }
                    }
                } while (loop);
                this.Show();
            }
                    
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}