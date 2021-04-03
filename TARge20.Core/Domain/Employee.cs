using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// ESIMENE HINDELINE HARJUTUS
        /// 
        /// Teha Code First ja Database First Migration
        /// Teha word dokumendile töökäik koos piltidega.
        /// Kindlasti tahan näha MS SQL DB-st pilti enne migrationit ja peale seda.


        /// TEINE HINDELINE HARJUTUS
        ///
        /// Teha Teie meeskonna poolt esitletud FIRMA DB-st objektide struktuur. Kui see on valmis, siis teha code first migration.
        /// NB! Kasutate enda meeskonna poolt esitatud Firma DB ERD-d, aga igaüks teeb individuaalselt.
        /// Kogu solution laadida GitHubi ja link valmis tööst saata mulle.

        /// Mõned muutujad võivad olla ka NULL väärtusega ja need tuleb ära märkida

        /// kui peate tõmbama mingeid packagesi alla, siis kasutage eelistatult microsofti omasid ning latest stabel versiooni

        /// <summary>
        /// Kui kasutate enumit, siis peate olema kindel, et on tegemist valikutega, mis jäävad kogu rakenduse eluajaks samaks.
        /// </summary>
        //public Gender Gender { get; set; }

        /// <summary>
        /// 
        /// Siin on info ja analüüs, et mis varianti kasutada
        /// https://stackoverflow.com/questions/10113244/why-use-icollection-and-not-ienumerable-or-listt-on-many-many-one-many-relatio/10113331
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?redirectedfrom=MSDN&view=net-5.0
        /// 
        /// </summary>
        //public IEnumerable<Children> Childrens { get; set; } = new List<Children>();
        //public ICollection<Children> Childrens1 { get; set; }
        //public List<Children> Childrens2 { get; set; }
    }


    //public enum Gender
    //{
    //    Female, 
    //    Male,
    //    Unknown
    //}

    //public class Children
    //{
    //    [Key]
    //    public Guid Id { get; set; }

    //    public string FirstName { get; set; }
    //}
}
