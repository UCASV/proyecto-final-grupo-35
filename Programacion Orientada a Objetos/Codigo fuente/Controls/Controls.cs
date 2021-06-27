using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using VaccinationManagement.Context;
using VaccinationManagement.Models;
using VaccinationManagement.Views;

namespace VaccinationManagement.Controls
{
    public static  class ShowStadistics
    {
        private static List<Citizen> citizensTotalVaccinated;
        private static List<Citizen> citizensSecondVaccinated;
        public static void DrawGraphics(object sender, PaintEventArgs e)
        {
            GetData();
            var brush = new SolidBrush(Color.White);
            var penBar = new Pen(brush, 50); 
            var font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            var canva = e.Graphics;

            //Abre un contenedor para dibujar los datos
            var DataContainer = canva.BeginContainer();
            
            canva.DrawString($"Total de personas vacunadas: {citizensTotalVaccinated.Count}", font, brush , 10,25);
            canva.DrawString($"Personas vacunadas (Solo primera dosis) : {citizensTotalVaccinated.Count}", font, brush , 10,45);
            canva.DrawString($"Personas vacunadas (Ambas dosis) : {citizensSecondVaccinated.Count}", font, brush , 10,65);
            canva.EndContainer(DataContainer);        
            ///////////////////////////////////////////

            var Graphic = canva.BeginContainer();
            
            canva.DrawLine(penBar, 35, 100, 35, 400 );
            
            canva.EndContainer(Graphic);        


        }

        private static void GetData()
        {
            var db = new VaccinationContext();
            var appointments = from B in db.Booths
                join E in db.Employees on B equals E.IdBoothNavigation
                join C in db.Citizens on E equals C.IdEmployeeNavigation
                join A in db.Appointments on C equals A.IdCitizenNavigation
                where A.VaccineDate != null && A.IdAppointmentType == 1
                select C;
            
            var appointmentsSecondType = from B in db.Booths
                join E in db.Employees on B equals E.IdBoothNavigation
                join C in db.Citizens on E equals C.IdEmployeeNavigation
                join A in db.Appointments on C equals A.IdCitizenNavigation
                where  A.VaccineDate != null && A.IdAppointmentType == 2
                select C;
            
        citizensTotalVaccinated = appointments.ToList();
        citizensSecondVaccinated = appointmentsSecondType.ToList();
        }
        
        
    }
    
}