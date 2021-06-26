using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class SideEffect
    {
        public int Id { get; set; }
        public string Effect { get; set; }
        public DateTime EffectTime { get; set; }
        public int IdAppointment { get; set; }

        public virtual Appointment IdAppointmentNavigation { get; set; }

        public Appointment Appointment { get; set; }
    }
}
