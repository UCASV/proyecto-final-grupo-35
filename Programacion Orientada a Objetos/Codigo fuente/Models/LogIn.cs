using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class LogIn
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdBooth { get; set; }
        public DateTime DateTime { get; set; }

        public virtual Booth IdBoothNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
