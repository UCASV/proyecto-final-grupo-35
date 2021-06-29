using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VaccinationManagement.Context;
using VaccinationManagement.Models;
using VaccinationManagement.Views;

namespace VaccinationManagement.Controls
{
    public static class Printer
    {
        public static Appointment AppointmentData;
        public static void PrintPdf(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var datetimeFont = new Font("Arial", 10, FontStyle.Regular);
            var listFont = new Font("Arial", 12, FontStyle.Regular);
            var printFont = new Font("Arial", 14, FontStyle.Regular);
            var subTitleFont = new Font("Arial", 16, FontStyle.Bold);
            var headerFont = new Font("Arial", 18, FontStyle.Regular);
            var db = new VaccinationContext();

            var citizen = db.Citizens.Where(
                C => C.Dui == AppointmentData.IdCitizen).ToList().First();
            var type = db.AppointmentTypes.Where(
                A => A.Id == AppointmentData.IdAppointmentType).ToList().First();
            var priorityGroup = db.PriorityGroups.Where(p => p.Id == citizen.IdPriorityGroup).ToList().First();
            ///Text to add
            ///
            ///
            string dui = $" \tDUI: {citizen.Dui}";
            string name = $" \tNombre: {citizen.CitizenName}";
            string group = $"\tPertenece a {priorityGroup}";
            
            string date = $" \tFecha de la cita: {AppointmentData.AppointmentDate.ToShortDateString()}" +
                          $"  {AppointmentData.AppointmentDate.ToShortTimeString()}";
            string location = $" \tLugar de vacunacion {AppointmentData.AppointmentLocation}";
            string typeAppointemt = $" \tTipo de cita: {type.AppointmentType1}";

            
            string header = $"Programacion de {type.AppointmentType1} para aplicacion de vacuna contra el COVID-19 ";
            // Draw the content.
            
            //HEADER
            e.Graphics.DrawImage(Image.FromFile("./Resources/LogoGobierno_200px_black.png"), 50, 50 );
            e.Graphics.DrawString(header, headerFont, Brushes.Black, 
                new RectangleF(125, 200, 700, 300), 
                new StringFormat(StringFormatFlags.LineLimit));
            
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), datetimeFont,
                Brushes.Black, 700, 50 );
            e.Graphics.DrawString(DateTime.Now.ToShortTimeString(), datetimeFont,
                Brushes.Black, 700, 65 );
            
            
            //INFO
            var y0 = 300;
            var interlineado = 50;
            
                    //////////////////////
            e.Graphics.DrawString("Datos Personales ", subTitleFont, Brushes.Black, 50, y0);
            
            e.Graphics.DrawString(name, printFont, Brushes.Black, 50, y0 += interlineado);
            e.Graphics.DrawString(dui, printFont, Brushes.Black, 50, y0 += interlineado);

                    
                    //////////////////////
            e.Graphics.DrawString("Programacion de cita", subTitleFont, Brushes.Black, 50, y0 += interlineado);
            
            e.Graphics.DrawString(typeAppointemt, printFont, Brushes.Black, 50, y0 += interlineado);
            e.Graphics.DrawString(date, printFont, Brushes.Black, 50, y0 += interlineado);
            e.Graphics.DrawString(location, printFont, Brushes.Black, 50, y0 += interlineado);

            //Recomendaciones :
            e.Graphics.DrawString("Recomendaciones", subTitleFont, Brushes.Black, 50, y0 += interlineado);

            var r1 = " \t• Ir acompañado de una persona";
            var r2 = " \t• Estar 15 minutos antes de la cita";
            var r3 = " \t• Portar su DUI";
            
            
            e.Graphics.DrawString(r1, listFont, Brushes.Black, 50, y0 += interlineado);
            e.Graphics.DrawString(r2, listFont, Brushes.Black, 50, y0 += interlineado);
            e.Graphics.DrawString(r3, listFont, Brushes.Black, 50, y0 += interlineado);

            //Advertencia: 
            e.Graphics.DrawString("Advertencias", subTitleFont, Brushes.Black, 50, y0 += interlineado);

            var a1 = "\t• Evitar que terceras personas realizen una copia de este documento";
            e.Graphics.DrawString(a1, listFont, Brushes.Black, 50, y0 += interlineado);

             
            
        }
    }
}