using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using VaccinationManagement.Context;
using VaccinationManagement.Controls;
using VaccinationManagement.Models;

namespace VaccinationManagement.Views
{
    [SuppressMessage("ReSharper", "InvalidXmlDocComment")]
    public partial class AppointmentProcess
    {
        public Appointment NewAppointment;
        private bool CheckForAllBox()
        {
            var allBoxsFilled = !Txbx_DUI.Text.Equals("") &&
                                 !txtb_name.Text.Equals("") && 
                                 !txtbx_addres.Text.Equals("") &&                           
                                 !txtbx_phone.Text.Equals("") &&
                                 !txtb_ICode.Text.Equals("");

            return allBoxsFilled;
        }

        private void FillBoxes(Citizen citizen)
        {
            var db = new VaccinationContext();
            
            updateMode = true;
            duiToChange = citizen.Dui;
            
            Txbx_DUI.Text = $"{citizen.Dui}";
            txtb_name.Text = citizen.CitizenName;
            txtbx_addres.Text = citizen.CitizenAddress;
            txtbx_email.Text = citizen.Email;
            txtbx_phone.Text = $"{citizen.Phone}";
            txtb_ICode.Text = $"{citizen.IntitutionCode}";
            cbx_institution.SelectedItem = db.SpecialInstitutions.Where(
                S => S.Id == citizen.IdSpecialInstitution).ToList().First();
            cbx_pgroup.SelectedItem = db.PriorityGroups.Where(
                p => p.Id == citizen.IdPriorityGroup).ToList().First();
        }

        private void AddOrUpdateCitizenData()
        {
            var db = new VaccinationContext();
            var priorityGroup = (PriorityGroup) cbx_pgroup.SelectedItem;
            var specialInstitucion = (SpecialInstitution) cbx_institution.SelectedItem;

            ///La variable UpdateMode determina si se va a actualizar los datos
            /// o a crear nuevo registro   
            if (updateMode)
            {
                var citizenToChange = db.Citizens.Where(c => c.Dui == duiToChange).ToList()[0];

                citizenToChange.Dui = Int32.Parse(Txbx_DUI.Text);
                citizenToChange.CitizenName = txtb_name.Text;
                citizenToChange.CitizenAddress = txtbx_addres.Text;
                citizenToChange.Email = txtbx_email.Text;
                citizenToChange.Phone = Int32.Parse(txtbx_phone.Text);
                citizenToChange.IntitutionCode = Int32.Parse(txtb_ICode.Text);
                citizenToChange.IdSpecialInstitution = specialInstitucion.Id;
                citizenToChange.IdPriorityGroup = priorityGroup.Id;


                var update = new FrmInformationUpdate().ShowDialog();
                

                db.SaveChanges();
                Close();

            }
            else
            {
                var citizen = new Citizen(
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

                db.Citizens.Add(citizen);
                db.SaveChanges();

                var save = new FrmInformationSave().ShowDialog();
                

                /*
                * Generar primera cita 
                */

                var r = new Random();
                NewAppointment = new Appointment()
                {
                    AppointmentLocation = LocationData.LocationActualBooth,
                    AppointmentDate = DateTime.Now.AddDays(r.Next(14, 21)),
                    IdAppointmentType = 1,
                    IdCitizen = Convert.ToInt32(Txbx_DUI.Text),

                };

                db.Appointments.Add(NewAppointment);
                db.SaveChanges();

                using (var citeDates =
                    new FrmCiteDates(
                        $"Se ha generado una cita nueva para el dui {Txbx_DUI.Text} \n Presiona 'OK' para imprimir una hoja con los datos de la nueva cita"))
                {
                    var result = citeDates.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Printer.AppointmentData = NewAppointment;
                        OpenPrinter();
                    }
                }

            }
        }

        private PrintDocument docToPrint;

        private void OpenPrinter()
        {
            docToPrint = new PrintDocument();
            
            docToPrint.PrintPage += Printer.PrintPdf; 
            // Allow the user to choose the page range he or she would
            // like to print.
            printDialog1.AllowSomePages = true;

            // Show the help button.
            printDialog1.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result==DialogResult.OK)
            {
                docToPrint.Print();
            }
        }
        
    }
}