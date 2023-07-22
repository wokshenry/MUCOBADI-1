using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AServiceCategory
    {
        public AServiceCategory()
        {
            AHomeVisitServicesNeeded = new HashSet<AHomeVisitServicesNeeded>();
            AServiceReceived = new HashSet<AServiceReceived>();
        }

        public int ServiceCategoryId { get; set; }
        public string ServiceCategoryDesc { get; set; }

        public virtual ICollection<AHomeVisitServicesNeeded> AHomeVisitServicesNeeded { get; set; }
        public virtual ICollection<AServiceReceived> AServiceReceived { get; set; }
    }
}
