using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class BranchOffice
    {
        [Key]
        public Guid Id { get; set; }

        public string RegistryNr { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
