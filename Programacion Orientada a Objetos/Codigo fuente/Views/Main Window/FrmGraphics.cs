using System;
using System.Windows.Forms;
using VaccinationManagement.Controls;


namespace VaccinationManagement.Views.Main_Window
{
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
            this.pnlWindow.Paint += new PaintEventHandler(ShowStadistics.DrawGraphics);
        }

        private void tmrHour_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}