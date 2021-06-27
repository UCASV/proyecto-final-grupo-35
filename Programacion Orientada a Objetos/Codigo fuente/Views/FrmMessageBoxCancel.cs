using System;
using System.Windows.Forms;
using VaccinationManagement.View;

namespace VaccinationManagement.Views
{
    public partial class FrmMessageBoxCancel : Form
    {
        public FrmMessageBoxCancel()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            AppointmentProcess yes = new AppointmentProcess();
            yes.Show();
            yes.Close();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}