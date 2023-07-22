using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewAserviceLinkedToCategory
    {
        public int ServiceLinkedToId { get; set; }
        public string ServiceLinkedToDesc { get; set; }
        public int LinkageServiceCategoryId { get; set; }
        public string LinkageServiceCategoryDesc { get; set; }
    }
}
