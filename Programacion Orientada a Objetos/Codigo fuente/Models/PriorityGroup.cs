using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class PriorityGroup
    {
        public PriorityGroup()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string PriorityGroup1 { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
