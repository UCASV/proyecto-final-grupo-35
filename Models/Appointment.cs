using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            SideEffects = new HashSet<SideEffect>();
        }

        public int Id { get; set; }
        public string AppointmentLocation { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime Step2Date { get; set; }
        public DateTime VaccineDate { get; set; }
        public int IdAppointmentType { get; set; }
        public int IdCitizen { get; set; }

        public virtual AppointmentType IdAppointmentTypeNavigation { get; set; }
        public virtual Citizen IdCitizenNavigation { get; set; }
        public virtual ICollection<SideEffect> SideEffects { get; set; }
    }
}
