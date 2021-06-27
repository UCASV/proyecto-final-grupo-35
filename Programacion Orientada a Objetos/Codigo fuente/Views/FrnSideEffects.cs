using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using VaccinationManagement.Context;
using VaccinationManagement.Models;

namespace VaccinationManagement.Views
{
    public partial class FrnSideEffects : Form
    {
        private List<SideEffect> sideEffects;
        private Appointment selectedAppointment; 
        public FrnSideEffects(Appointment selectedAppointment)
        {
            this.selectedAppointment = selectedAppointment;
            sideEffects = new List<SideEffect>();
            
            InitializeComponent();
        }

        private void FrnSideEffects_Load(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            
            var sideEffectsTypes = db.SideEffectTypes.ToList();
            cmbEffectTypess.DataSource = sideEffectsTypes;
            cmbEffectTypess.DisplayMember = "Effect";
        }

      
        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new VaccinationContext();
                sideEffects.ForEach(effect =>
                {
                    db.SideEffects.Add(effect);
                });

                db.SaveChanges();
                
                MessageBox.Show("Se agregaron los efectos secundario desarrolados por el paciente.",
                    "Datos actualizados", MessageBoxButtons.OK);
                
                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show($"{exception}");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            var vaccinationDate = (DateTime) selectedAppointment.VaccineDate;

                try
                {
                    var sideEffect = new SideEffect()
                    {
                        IdAppointment = selectedAppointment.Id,
                        EffectTime = vaccinationDate.AddMinutes(
                            Int32.Parse(txtMinutes.Text)),
                        IdEffect = ((SideEffectType) cmbEffectTypess.SelectedItem).Id
                    };

                    sideEffects.Add(sideEffect);
                    
                    MessageBox.Show("Se agrego este registro. \n Presiona Terminar para cerrar y guardar",
                        "Se agrego", MessageBoxButtons.OK);

                }
                catch (FormatException exception)
                {
                    MessageBox.Show("Revisa los datos");
                }
                finally
                {
                    txtMinutes.Text = "";
                }
            
        }

    }
}