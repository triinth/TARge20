using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class HealthInspection
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Year { get; set; }
        public string Passed { get; set; }
        public string MedicalInstitution { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
