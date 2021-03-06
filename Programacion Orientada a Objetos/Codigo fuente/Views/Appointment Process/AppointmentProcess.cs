using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using VaccinationManagement.Context;
using VaccinationManagement.Controls;
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
        private List<Disease> diseases;
        private int? duiToChange; 
        
        private bool updateMode = false;

        public AppointmentProcess()
        {
            diseases = new List<Disease>();
            InitializeComponent();
        }
        
        public AppointmentProcess(Citizen? citizen)
        {            
            diseases = new List<Disease>();
            var db = new VaccinationContext();

            InitializeComponent();

            var priority_groups = db.PriorityGroups.ToList();
            cbx_pgroup.DataSource = priority_groups;
            cbx_pgroup.DisplayMember = "PriorityGroup1";

            var institutions = db.SpecialInstitutions.ToList();
            cbx_institution.DataSource = institutions;
            cbx_institution.DisplayMember = "InstName";
            
            if(citizen != null)
                FillBoxes(citizen);
        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            
            /*
             * Primero revisar si todos los TextBox han sido llenados
             * Si no se llenaron, se avisa y se regresa al formulario  
             */
            if (!CheckForAllBox())
            {
                var ErrorData = new FrmReviewData();
                var result = ErrorData.ShowDialog();
                if(result == DialogResult.OK)
                
                return;
            }
            
                
            try
            {
                AddOrUpdateCitizenData();
            }
            catch (FormatException exception)
            {
                MessageBox.Show($"Revisa los datos ");
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show($"Revisa los datos");
            }
            finally
            {
                //Agregar todas las enfemedades cronicas a la base de datos 
                diseases.ForEach(d =>
                {
                    db.Diseases.Add(d);
                    db.SaveChanges();
                });

                Close();
               
            }

        }

        

        private void btn_add_disease_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();

            try
            {
                Disease disease = new Disease(
                    txtbx_disease.Text,
                    Convert.ToInt32(Txbx_DUI.Text)
                    );
                    
                 diseases.Add(disease);
                 using (var add = new FrmAddDiseases())
                 {
                     var result = add.ShowDialog();
                     if (result == DialogResult.OK)
                     {
                         
                     }
                
                 }
                 txtbx_disease.Text = "";
                
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception);
            }
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