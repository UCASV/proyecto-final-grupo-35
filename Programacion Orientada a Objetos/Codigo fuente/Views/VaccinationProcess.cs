using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using VaccinationManagement.Context;
using VaccinationManagement.Controls;
using VaccinationManagement.Models;

namespace VaccinationManagement.Views
{
    public partial class VaccinationProcess : Form
    {
        
        private int dui;
        private Appointment appointmentToChange;

        public VaccinationProcess(int dui)
        {
            
            var db = new VaccinationContext();
            this.dui = dui;
            var citizenCheck = db.Citizens.Where(w => w.Dui == dui).ToList().Count;
            
            InitializeComponent();
            this.btnActualHour1.Click += new EventHandler(this.cmbTimeSelection);
            this.btnActualhour2.Click += new EventHandler(this.cmbTimeSelection);
            
        }
        

        ///// Event Handlers
        private void VaccinationProcess_Load(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var appointments = from B in db.Booths
                join E in db.Employees on B equals E.IdBoothNavigation
                join C in db.Citizens on E equals C.IdEmployeeNavigation
                join A in db.Appointments on C equals A.IdCitizenNavigation     
                where B.Id == LocationData.IdActualBooth && C.Dui == dui 
                select new AppointmentsVm(){
                    Codigo_Cita = A.Id, 
                    DUI = $"0{C.Dui}",
                    Ciudadano = C.CitizenName,
                    Fecha_Cita = A.AppointmentDate, 
                    Tipo_Cita = A.IdAppointmentTypeNavigation.AppointmentType1
                    
                }; 

            dgvAppointment.DataSource = appointments.ToList();
            updateDataMode();
            
        }

        private void updateDataMode()
        {
            var db = new VaccinationContext();
            DateTime AppointmentDate = DateTime.Parse(dgvAppointment.SelectedRows[0].Cells[3].Value.ToString());
            lblAppointmentDate.Text = AppointmentDate.ToShortDateString();
            lblAppointmentDate2.Text = AppointmentDate.ToShortDateString();
            
            var actualAppointmentId = Int32.Parse(dgvAppointment.SelectedCells[0].Value.ToString());
            appointmentToChange = db.Appointments.Where(A => A.Id == actualAppointmentId).ToList()[0];

                /*
                    Para evitar incosistencias en los datos, se llenan las opciones de horas 
                    desde la hora establecida por la plataforma en la cita seleccionada
                */
                cmbHourStep2.Items.Clear();
                cmbHourStep2.Items.Add("hh");
                cmbHourStep2.SelectedItem = "hh";
                for (var i = AppointmentDate.Hour; i < 24; i++)
                {
                    cmbHourStep2.Items.Add(i);
                }

                cmbHourVaccination.Items.Clear();
                cmbHourVaccination.Items.Add("hh");
                cmbHourVaccination.SelectedItem = "hh";
                for (var i = AppointmentDate.Hour; i < 24; i++)
                {
                    cmbHourVaccination.Items.Add(i);
                }

                
                ///Se añaden los minutos a los ComboBox
                cmbMinuteStep2.Items.Clear();
                cmbMinuteStep2.Items.Add("mm");
                cmbMinuteStep2.SelectedItem = "mm";
                for (var i = 0; i < 60; i++)
                {
                    cmbMinuteStep2.Items.Add(i);
                }


                cmbMinuteVaccination.Items.Clear();
                cmbMinuteVaccination.Items.Add("mm");
                cmbMinuteVaccination.SelectedItem = "mm";
                for (var i = 0; i < 60; i++)
                {
                    cmbMinuteVaccination.Items.Add(i);
                }

            


        }
        
        private void dgvCellClicked (object sender, DataGridViewCellEventArgs e)
        {
            // A cada click se actualizan las horas y minutos que se pueden seleccionar
            updateDataMode();
        }
        
        ////// Eventos botones "Ahora"  
        private void btnNowButtonStep2Event(object sender, EventArgs e)
        {
            cmbHourStep2.SelectedItem = DateTime.Now.Hour;
            cmbMinuteStep2.SelectedItem = DateTime.Now.Minute;
        }
        
        private void btnNowButtonVaccinationEvent(object sender, EventArgs e)
        {
            
                cmbHourVaccination.SelectedItem = DateTime.Now.Hour;
                cmbMinuteVaccination.SelectedItem = DateTime.Now.Minute;

        }
        ///////////////////////////////

        private void btnSideEffectsClick(object sender, EventArgs e)
        {
            using (var sideEffectForm = new FrnSideEffects(appointmentToChange))
            {
                Hide();
                sideEffectForm.ShowDialog();
                Show();
            }
        }
     
        private void btnUpdateDataClick(object sender, EventArgs e)
        {
            DateTime? vaccineDate, step2Date;
            var r = new Random();
            var db = new VaccinationContext();
            var actualBooth = db.Booths.Where(B => B.Id == LocationData.IdActualBooth).ToList().First();
            var actualAppointmentId = Int32.Parse(dgvAppointment.SelectedCells[0].Value.ToString());
            appointmentToChange = db.Appointments.Where(A => A.Id == actualAppointmentId).ToList()[0];


            //Generar segunda cita
            var secondVaccinationAppointment = new Appointment() 
            {
                    AppointmentLocation = actualBooth.BoothAddress,
                    AppointmentDate = appointmentToChange.AppointmentDate.AddDays(r.Next(42, 56)),
                    Step2Date = null,
                    VaccineDate = null,
                    IdAppointmentType = 2,
                    IdCitizen = appointmentToChange.IdCitizen,
                    IdAppointmentTypeNavigation = db.AppointmentTypes.Where(AT => AT.Id == 2).ToList()[0],
                    IdCitizenNavigation = db.Citizens.Where(C => C.Dui == appointmentToChange.IdCitizen).ToList()[0]
            };

            //Llenar los datos faltantes en citas modificandose 
            if (!cmbHourStep2.SelectedItem.Equals("hh") && !cmbMinuteStep2.SelectedItem.Equals("mm"))
            {
                step2Date =
                    DateTime.Parse(
                        $"{lblAppointmentDate.Text} {cmbHourStep2.SelectedItem.ToString()}:{cmbMinuteStep2.SelectedItem.ToString()}");
            }
            else
            {
                step2Date = null;
            }

            if (!cmbHourVaccination.SelectedItem.Equals("hh") && !cmbMinuteVaccination.SelectedItem.Equals("mm"))
            {
                vaccineDate =
                    DateTime.Parse(
                        $"{lblAppointmentDate.Text} {cmbHourVaccination.SelectedItem.ToString()}:{cmbMinuteVaccination.SelectedItem.ToString()}");
            }
            else
            {
                vaccineDate = null;
            }
            
            
            try 
            {
                appointmentToChange.Step2Date = step2Date;
                appointmentToChange.VaccineDate = vaccineDate;
                
                if (appointmentToChange.IdAppointmentType == 1)
                {
                    db.Appointments.Add(secondVaccinationAppointment);
                    MessageBox.Show(
                        $"Se ha generado la siguiente cita del paciente: {secondVaccinationAppointment.AppointmentDate}, {secondVaccinationAppointment.AppointmentLocation}",
                        "Generado con exito", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("El paciente ha completado su registro de vacunacion ",
                        "Completado", MessageBoxButtons.OK);
                    Close();
                }

                //Debemos volver a bloquear el boton luego de actualizar los datos a la base de datos
                this.btnUpdateData.Enabled = false;


            }
            catch (Exception exception)
            {
                    MessageBox.Show(appointmentToChange.Step2Date.ToString()); 
                    Console.WriteLine(exception);
                    throw;
            }

            db.SaveChanges();


        }

        private void cmbTimeSelection(object sender, EventArgs e)
        {
            if (
                !cmbHourStep2.SelectedItem.Equals("hh") &&
                !cmbMinuteStep2.SelectedItem.Equals("mm")
                )
            {
                this.btnUpdateData.Enabled = true;
            }
            else if (
                !cmbHourVaccination.SelectedItem.Equals("hh") &&
                !cmbMinuteVaccination.SelectedItem.Equals("mm")
                )
            {
                this.btnUpdateData.Enabled = true;
            }

        
        }

    }
    
}