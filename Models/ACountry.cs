using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACountry
    {
        public ACountry()
        {
            AContacts = new HashSet<AContacts>();
        }

        public int CountryId { get; set; }
        public string CountryDesc { get; set; }
        public string DialCode { get; set; }

        public virtual ICollection<AContacts> AContacts { get; set; }
    }
}
