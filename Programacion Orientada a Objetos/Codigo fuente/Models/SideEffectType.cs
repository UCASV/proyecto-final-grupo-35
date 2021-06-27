using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class SideEffectType
    {
        public SideEffectType()
        {
            SideEffects = new HashSet<SideEffect>();
        }

        public int Id { get; set; }
        public string Effect { get; set; }

        public virtual ICollection<SideEffect> SideEffects { get; set; }
    }
}
