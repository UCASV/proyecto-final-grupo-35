using System.Windows.Forms;
using VaccinationManagement.Context;
using VaccinationManagement.Models;

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
    }
}