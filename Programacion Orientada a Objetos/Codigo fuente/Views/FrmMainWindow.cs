using System;
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

        public void btnUpdateDataView_click(object Sender, EventArgs e)
        {
            using (var vaccinationProcessLogin = new FrmGetDui())
            {
                var loop = true;
                do
                {
                        
                    var dialogResult = vaccinationProcessLogin.ShowDialog();
                    var dui = Int32.Parse(vaccinationProcessLogin.textBox1.Text);
                    
                    if (dialogResult == DialogResult.OK)
                    {
                        try
                        {
                            Int32.Parse(vaccinationProcessLogin.textBox1.Text);
                            MessageBox.Show($"DUI: {vaccinationProcessLogin.textBox1.Text}");
                            
                            var vaccinationProcess = new VaccinationProcess(dui); 
                            Hide();
                            vaccinationProcess.ShowDialog();
                            Show();
                            loop = false;
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
         
    }
}