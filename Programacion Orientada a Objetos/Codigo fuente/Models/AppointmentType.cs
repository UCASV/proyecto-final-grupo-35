using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class AppointmentType
    {
        public AppointmentType()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string AppointmentType1 { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
