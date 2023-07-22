using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewServiceRecieved
    {
        public int ServiceReceivedId { get; set; }
        public string ServiceClassiffication { get; set; }
        public string ServiceReceivedDesc { get; set; }
        public int ServiceCategoryId { get; set; }
        public string ServiceCategoryDesc { get; set; }
    }
}
