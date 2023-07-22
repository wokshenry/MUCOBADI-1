using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewAHomeVisitServicesNeeded
    {
        public int ServiceNeededId { get; set; }
        public int ServiceCategoryId { get; set; }
        public string ServiceCategoryDesc { get; set; }
        public string ServiceClassiffication { get; set; }
        public string ServiceNeededDesc { get; set; }
    }
}
