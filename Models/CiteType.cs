using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class CiteType
    {
        public CiteType()
        {
            Cites = new HashSet<Cite>();
        }

        public int Id { get; set; }
        public string CiteType1 { get; set; }

        public virtual ICollection<Cite> Cites { get; set; }
    }
}
