using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VaccinationManagement.Context;
using VaccinationManagement.Controls;
using VaccinationManagement.Models;
using VaccinationManagement.View;

namespace VaccinationManagement.Views
{
    public partial class Frmverification : Form
    {
        public Button btnVerification;
        public Button btnVerificationPrint;
        
        public Citizen CitizenToChange;
        
        public Frmverification()
        {
            InitializeComponent();
            btnVerificationPrint.Click += btnOpenPrinter;
            
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            
            //
            if (textBox1.Text.Equals(""))
            {
                using (var invalid = new FrmInvalidData())
                {
                    var result = invalid.ShowDialog();
                    if (result == DialogResult.OK)
                        return;
                }
            }
            
            //
            try
            {
                var citizen = (from B in db.Booths
                    join E in db.Employees on B equals E.IdBoothNavigation
                    join C in db.Citizens on E equals C.IdEmployeeNavigation
                    join A in db.Appointments on C equals A.IdCitizenNavigation
                    where B.Id == LocationData.IdActualBooth && C.Dui == Int32.Parse(textBox1.Text)
                    select C).ToList().First();
                
                
                new FrmCitationFound().ShowDialog();

                Hide();
                CitizenToChange = citizen;
                
                
            }
            catch (InvalidOperationException exception)
            {
                var cita = new FrmCitesInTheFound();

                var result = cita.ShowDialog();
                if(result == DialogResult.OK)
                
                if (result == DialogResult.OK)
                {
                    Hide();
                    CitizenToChange = null;
                }
                
            }
            catch (FormatException exception)
            {
                using (var invalid = new FrmInvalidData())
                {
                    var result = invalid.ShowDialog();
                    if (result == DialogResult.OK);
                }
            }
        }
        public Appointment LastAppointment;

        private void btnOpenPrinter(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            
            //
            if (textBox1.Text.Equals(""))
            {
                using (var invalid = new FrmInvalidData())
                {
                    var result = invalid.ShowDialog();
                    if (result == DialogResult.OK)
                        return;
                }
            }
            try
            {
                LastAppointment = db.Appointments.Where(
                    W => W.IdCitizen == Int32.Parse(textBox1.Text)).ToList().First();                    
            }
            catch (InvalidOperationException exeption)
            {
                    return;        
            }
            catch (FormatException exeption)
            {
                    return;        
            }
            
            using (var citeDates = new FrmCiteDates(
                    $"Se ha encontrado una cita para el dui {textBox1.Text} \n Presiona 'OK' para imprimir una hoja con los datos de la " +
                    $"más reciente cita")
                    )
            {
                
                var result = citeDates.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Printer.AppointmentData = null;
                    Printer.AppointmentData = LastAppointment;
                    OpenPrinter();
                }
                
            }
        }
        
        private PrintDocument docToPrint;

        private void OpenPrinter()
        {
            // Allow the user to choose the page range he or she would
            // like to print.
            printDialog1.AllowSomePages = true;

            docToPrint = new PrintDocument();
            
            docToPrint.PrintPage += Printer.PrintPdf; 

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