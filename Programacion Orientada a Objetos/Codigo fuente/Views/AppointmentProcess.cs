using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VaccinationManagement.Context;
using VaccinationManagement.Models;


namespace VaccinationManagement.Views
{
    public partial class AppointmentProcess : Form
    {
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.TextBox txtbx_addres;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.TextBox txtbx_disease;
        private System.Windows.Forms.ComboBox cbx_institution;
        private System.Windows.Forms.TextBox txtbx_phone;
        private System.Windows.Forms.ComboBox cbx_pgroup;

        public AppointmentProcess()
        {
            InitializeComponent();
        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var employee = db.Employees.ToList();
            var specialInstitucion = (SpecialInstitution) cbx_institution.SelectedItem;
            var priorityGroup = (PriorityGroup) cbx_pgroup.SelectedItem;

            Citizen citizen = new Citizen(
                Convert.ToInt32(Txbx_DUI.Text),
                txtb_name.Text,
                txtbx_addres.Text,
                Convert.ToInt32(txtbx_phone.Text),
                txtbx_email.Text,
                Convert.ToInt32(txtb_ICode.Text),
                LocationData.GestorId,
                specialInstitucion.Id,
                priorityGroup.Id
            );

            try
            {
                db.Citizens.Add(citizen);
                db.SaveChanges();

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Revisa los datos {exception}");
            }
            
            MessageBox.Show("Información guardada con exito", "Guardado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FrmMessageBoxCancel cancel = new FrmMessageBoxCancel();
            cancel.Show();
        }

        private void btn_add_disease_Click(object sender, EventArgs e)
        {
           
            Disease disease = new Disease(
                
                txtbx_disease.Text,
                Convert.ToInt32(Txbx_DUI.Text));
            var db = new VaccinationContext();
            db.Add(disease);
            db.SaveChanges();
        }

        private void AppointmentProcess_Load(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var priority_groups = db.PriorityGroups.ToList();
            cbx_pgroup.DataSource = priority_groups;
            cbx_pgroup.DisplayMember = "PriorityGroup1";

            var institutions = db.SpecialInstitutions.ToList();
            cbx_institution.DataSource = institutions;
            cbx_institution.DisplayMember = "InstName";
            
        }
    }
}