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
        /// Nõuded ja tegevus:
        /// 1. Kui tahate, siis võite forkida minu projekti GitHubist ja läbi Sourcetree enda arvutisse tõmmata.
        /// 2. See teeb teil teise hindelise ülesande tegemise lihtsamaks 
        /// kuna siis on ainult vaja commitida ja pushida.
        /// 3. Teha Code First ja Database First Migration
        /// 4. Teha word dokumendile töökäik koos piltidega ja detailne. Mitte, et vajuta seda ja mina sinna ning siis on valmis. 
        /// St, et kui mina hakkan teie õpetust jäljendama, siis ma saan selle tehtud.
        /// 5. Kindlasti tahan näha MS SQL DB-st pilti enne migrationit ja peale seda.


        /// TEINE HINDELINE HARJUTUS
        ///
        /// 1. Teha Teie meeskonna poolt esitletud FIRMA DB-st objektide struktuur. 
        /// 2. Kui see on valmis, siis teha code first migration.
        /// 3. NB! Kasutate enda meeskonna poolt esitatud FirmaDB ERD-d, aga igaüks teeb individuaalselt.
        /// 4. Kogu solution laadida GitHubi ja link valmis tööst saata mulle.
        /// 5. Järgmisena teha print screen MS SQL-s database diagrams all auto-genereeritud ERD-st pilt. See lisada sama projekti alla GitHubis.

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
