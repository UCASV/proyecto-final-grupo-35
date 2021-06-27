using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class SpecialInstitution
    {
        public SpecialInstitution()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string InstName { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
