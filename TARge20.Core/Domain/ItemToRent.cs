using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class ItemToRent
    {
        [Key]
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string Descriptio { get; set; }
        public string Comment { get; set; }
        public string Availability { get; set; }


        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
