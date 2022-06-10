using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Hint
    {
        [Key]
        public Guid Id { get; set; }
        public string HintText { get; set; }
        public DateTime Date { get; set; }

        public Guid BranchOfficeId { get; set; }
        public BranchOffice BranchOffice { get; set; }

    }
}
