using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public string RegistryNr { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        public List<BranchOffice> BranchOffices { get; set; }
        public List<AccessPermition> AccessPermitions { get; set; }
        public List<Hint> Hints { get; set; }
        public List<Request> Requests { get; set; }
        public List<ItemToRent> itemToRents { get; set; }
    }
}
