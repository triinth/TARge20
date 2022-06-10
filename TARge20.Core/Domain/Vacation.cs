using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Vacation
    {
        [Key]
        public Guid Id { get; set; }
        public string VacationName { get; set; }
        public string VacationType { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public int HolidayBalance { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
