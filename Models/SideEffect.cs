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
        public int IdCite { get; set; }

        public virtual Cite IdCiteNavigation { get; set; }
    }
}
