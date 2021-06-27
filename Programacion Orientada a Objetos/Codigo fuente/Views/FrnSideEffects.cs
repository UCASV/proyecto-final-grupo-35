using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
            var db = new VaccinationContext();
            sideEffects.ForEach(effect =>
            {
                db.SideEffects.Add(effect);
            });

            db.SaveChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedAppointment.VaccineDate != null)
            {
                var vaccinationDate = (DateTime) selectedAppointment.VaccineDate;

                try
                {
                    var sideEffect = new SideEffect()
                    {
                        IdAppointmentNavigation = selectedAppointment,
                        EffectTime =  vaccinationDate.AddMinutes(
                            Int32.Parse(txtMinutes.Text)), 
                        IdEffectNavigation = (SideEffectType)cmbEffectTypess.SelectedItem
                    };
                
                    sideEffects.Add(sideEffect);
            
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Revisa los datos");
                }
            }
        }

    }
}