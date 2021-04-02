using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Employee
    {



        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        /// kui peate tõmbama mingeid packagesi alla, siis kasutage eelistatult microsofti omasid ning latest stabel versiooni

        /// <summary>
        /// Kui kasutate enumit, siis peate olema kindel, kas on tegemist valikutega, mis jäävad kogu rakenduse ajaks samaks.
        /// Kui need hakkavad muutuma, siis ei soovita seda kasutada.
        /// Nt, inimese soo osas jäävad allpool välja toodud väärtused samaks. Väga väike võimalus, et need väärtused muutuvad.
        /// </summary>
        //public Gender Gender { get; set; }


        /// <summary>
        /// Siin on info ja analüüs, et mis varianti kasutada
        /// https://stackoverflow.com/questions/10113244/why-use-icollection-and-not-ienumerable-or-listt-on-many-many-one-many-relatio/10113331
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?redirectedfrom=MSDN&view=net-5.0
        /// 
        /// võite kasutada ka public virtual või lihtsalt publicut.
        /// </summary>
        public virtual IEnumerable<Children> Childrens { get; set; } = new List<Children>();
        public ICollection<Children> Childrens1 { get; set; }
        public List<Children> Childrens2 { get; set; }
    }


    //public enum Gender
    //{
    //    Female, 
    //    Male,
    //    Unknown
    //}

    public class Children
    {
        /// <summary>
        /// mida tähendab ? peale guid-i?
        /// </summary>
        public Guid Id { get; set; }

        public Employee EmployeeId { get; set; }
    }
}
