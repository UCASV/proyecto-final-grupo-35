using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using VaccinationManagement.Context;
using VaccinationManagement.Models;
using System.Runtime.InteropServices;

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
                
                MessageBox.Show("Se agregaron los efectos secundario desarrollados por el paciente.",
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
            if (selectedAppointment.VaccineDate != null)
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
            else
            {
                MessageBox.Show("Para agregar estos datos debe registrar la hora de vacunacion del paciente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            using (var cancel = new FrmClose())
            {
                var result = cancel.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                                                                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void FrnSideEffects_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}