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

        private void btnUpdateDataView_click(object sender, EventArgs e)
        {
            //Se asignó al boton 
            var vaccinationProcessLogin = new FrmGetDui();
           
            // Abrir un formulario para verificar el Dui 
            Hide();
            vaccinationProcessLogin.ShowDialog();
            Show();             
          
                    
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}