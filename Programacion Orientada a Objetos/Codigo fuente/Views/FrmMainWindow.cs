using System;
using System.Windows.Forms;
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
            
            using (var VP = new VaccinationProcess())
            {
                VP.ShowDialog();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}