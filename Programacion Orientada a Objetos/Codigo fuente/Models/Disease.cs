using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class Disease
    {
        public int Id { get; set; }
        public string Disease1 { get; set; }
        public int? IdCitizen { get; set; }

        public virtual Citizen IdCitizenNavigation { get; set; }

        public Disease (int Id, string disease1, int? idCitizen)
        {
            this.Id = Id;
            this.Disease1 = disease1;
            this.IdCitizen = idCitizen;
        }
    }
}
