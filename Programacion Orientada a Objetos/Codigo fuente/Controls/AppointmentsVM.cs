using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace VaccinationManagement.Controls
{
    public class AppointmentsVm 
    {
        public int Codigo_Cita { get; set; }
        
        public string DUI { get; set; }
        public string Ciudadano { get; set; }
        public DateTime Fecha_Cita { get; set; }
        public string Tipo_Cita { get; set; }

        public AppointmentsVm()
        {
            
        }
    }
}