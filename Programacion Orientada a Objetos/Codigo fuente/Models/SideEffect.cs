using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class SideEffect
    {
        public int Id { get; set; }
        public DateTime? EffectTime { get; set; }
        public int IdAppointment { get; set; }
        public int? IdEffect { get; set; }

        public virtual Appointment IdAppointmentNavigation { get; set; }
        public virtual SideEffectType IdEffectNavigation { get; set; }
    }
}
