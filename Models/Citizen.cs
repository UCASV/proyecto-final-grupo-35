using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
            Diseases = new HashSet<Disease>();
        }

        public int Dui { get; set; }
        public string CitizenName { get; set; }
        public string CitizenAddress { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int IntitutionCode { get; set; }
        public int IdEmployee { get; set; }
        public int IdSpecialInstitution { get; set; }
        public int IdPriorityGroup { get; set; }

        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual PriorityGroup IdPriorityGroupNavigation { get; set; }
        public virtual SpecialInstitution IdSpecialInstitutionNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Disease> Diseases { get; set; }
    }
}
