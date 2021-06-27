using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VaccinationManagement.Context;
using VaccinationManagement.Models;

namespace VaccinationManagement.Views
{
    public partial class Frmverification : Form
    {
        public Frmverification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var Citizen = db.Citizens.Where(w => Int32.Parse(textBox1.Text) == w.Dui).ToList();
            if(Citizen.Count != 0)
            {
                MessageBox.Show($"su cita esta confirmada");
            }
            else
            {
                MessageBox.Show($"usted no tiene una cita");
            }
            


        }


        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}