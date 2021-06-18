using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class User
    {
        public User()
        {
            Employees = new HashSet<Employee>();
            LogIns = new HashSet<LogIn>();
        }

        public int Id { get; set; }
        public string PasswordUser { get; set; }
        public string Users { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<LogIn> LogIns { get; set; }
    }
}
