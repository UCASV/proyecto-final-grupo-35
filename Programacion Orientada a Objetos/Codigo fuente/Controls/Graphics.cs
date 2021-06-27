using System;
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
    public class sideEffectsStatisticsClass
    {
        public string EffectName { set; get; }
        public int EffectFrequency { set; get; }
        
    }
    public static  class ShowStadistics
    {
        private static Graphics canva;
        private static List<Citizen> citizensTotalVaccinated;
        private static List<Citizen> citizensSecondVaccinated;
        private static List<SideEffect> sideEffects;
        private static List<sideEffectsStatisticsClass> sideEffectsStatistics;
        
        public static void DrawGraphics(object sender, PaintEventArgs e)
        {
            // 
            GetData();  
            //
            
            var brush = new SolidBrush(Color.White);
            var penBar = new Pen(brush, 50); 
            var font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            var fontGraphics = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            canva = e.Graphics;

            
            //Abre un contenedor para dibujar los datos
            var dataContainer = canva.BeginContainer();
            
            canva.DrawString($"Total de personas vacunadas: {citizensTotalVaccinated.Count}", font, brush , 10,25);
            canva.DrawString($"Personas vacunadas (Solo primera dosis) : {citizensTotalVaccinated.Count}", font, brush , 10,45);
            canva.DrawString($"Personas vacunadas (Ambas dosis) : {citizensSecondVaccinated.Count}", font, brush , 10,65);
            canva.EndContainer(dataContainer);        
            ///////////////////////////////////////////
            
            
            //Abre un contenedor para dibujar los datos
            DrawRule();
            ///////////////////////////////////////////
            
            
            
            /// Genera los graficos de barras
            var Graphic = canva.BeginContainer();
            
            canva.DrawString("Favor, estar antentos ante los efectos secundario con mas frecuencia", font, brush, 10, 85);
            
            var x0 = 75;
            var x0EffectName = 68;
            
            var y0 = 400;
            var y0EffectFrequency = 350;
            
            var lblFormat = new StringFormat(StringFormatFlags.DirectionVertical);
            var mostFrequencyEffects = sideEffectsStatistics.OrderByDescending(w => w.EffectFrequency).ToList();
            var mostFrequencyEffect = mostFrequencyEffects[0];
            var xMax = mostFrequencyEffect.EffectFrequency;
                
            mostFrequencyEffects.ForEach(frequency => { 
                
                
                var TopY = Map(frequency.EffectFrequency, xMax);
                
                canva.DrawString(frequency.EffectName, fontGraphics,
                    brush, new RectangleF(x0EffectName, 425, x0 + 150, 750), lblFormat);
                
                canva.DrawString($"{frequency.EffectFrequency}", fontGraphics, brush, x0, TopY-25);
                
                
                canva.DrawLine(penBar, x0 , y0, x0, y0+5);
                canva.DrawLine(penBar, x0 , y0, x0, TopY);
                x0 += 70;       
                x0EffectName += 70;                        

            });
                       
            canva.EndContainer(Graphic);        
            ///////////////////////////////////////////


        }

        private static int Map(int x, int max)
        {
            var y = 0;
            var bottomY = 400;
            
            y = 400 - (250 * x)/max;
            return y;
        }
        
        private static void DrawRule()
        {
            var ruleContainer = canva.BeginContainer();
            var mostFrecuenceStat = sideEffectsStatistics.First();
            
            for (int i = mostFrecuenceStat.EffectFrequency ; i >= 0; i--)
            {
                
            }
            
            
            canva.EndContainer(ruleContainer); 
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

            var sideEffectsType = db.SideEffectTypes.ToList();
            sideEffectsStatistics = new List<sideEffectsStatisticsClass>();
            
            sideEffectsType.ForEach(sideEffectsType =>
            {
                var typeFrecuency = db.SideEffects.Where(sideEffect => sideEffect.IdEffect == sideEffectsType.Id)
                    .ToList();
                sideEffectsStatistics.Add(new sideEffectsStatisticsClass()
                {
                    EffectFrequency = typeFrecuency.Count,
                    EffectName = sideEffectsType.Effect
                });

            });
            
        citizensTotalVaccinated = appointments.ToList();
        citizensSecondVaccinated = appointmentsSecondType.ToList();
        }
        
        
    }
    
}