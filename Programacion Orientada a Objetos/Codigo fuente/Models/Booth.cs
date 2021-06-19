using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class Booth
    {
        public Booth()
        {
            Employees = new HashSet<Employee>();
            LogIns = new HashSet<LogIn>();
        }

        public int Id { get; set; }
        public string Manager { get; set; }
        public string BoothAddress { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<LogIn> LogIns { get; set; }
    }
}
