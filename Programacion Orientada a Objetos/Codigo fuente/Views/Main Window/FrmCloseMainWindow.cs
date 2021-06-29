using System;
using System.Windows.Forms;

namespace VaccinationManagement.Views.Main_Window
{
    public partial class FrmCloseMainWindow : Form
    {
        public FrmCloseMainWindow()
        {
            InitializeComponent();
            lblUser.Text = LocationData.GestorName;
        }

        private void tmrOne_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if(circularProgressBar1.Value == 100){
                tmrOne.Stop();
                tmrTwo.Start();
            }
        }


        private void tmrTwo_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                tmrTwo.Stop();
                this.Close();
            }
        }

        private void FrmCloseMainWindow_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value= 0;
            circularProgressBar1.Minimum= 0;
            circularProgressBar1.Maximum = 100; 
            tmrOne.Start();
        }
    }
}