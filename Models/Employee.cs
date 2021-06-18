using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationManagement.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmployeeType { get; set; }
        public int IdBooth { get; set; }
        public int? IdUser { get; set; }

        public virtual EmployeeType EmployeeTypeNavigation { get; set; }
        public virtual Booth IdBoothNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
