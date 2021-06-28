using System.Windows.Forms;

namespace VaccinationManagement.Views
{
    public partial class FrmCiteDates : Form
    {
        public FrmCiteDates(string text)
        {
            InitializeComponent();
            lblText.Text = text;
                 
        }
    }
}