using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class Cite
    {
        public Cite()
        {
            SideEffects = new HashSet<SideEffect>();
        }

        public int Id { get; set; }
        public string CiteLocation { get; set; }
        public DateTime CiteDate { get; set; }
        public DateTime Step2Date { get; set; }
        public DateTime VaccineDate { get; set; }
        public int IdCiteType { get; set; }
        public int IdCitizen { get; set; }

        public virtual CiteType IdCiteTypeNavigation { get; set; }
        public virtual Citizen IdCitizenNavigation { get; set; }
        public virtual ICollection<SideEffect> SideEffects { get; set; }
    }
}
