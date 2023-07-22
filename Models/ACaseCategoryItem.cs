using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACaseCategoryItem
    {
        public int CaseCategoryItemId { get; set; }
        public int? CaseCategoryId { get; set; }
        public string CaseCategoryItemDesc { get; set; }

        public virtual ACaseCategory CaseCategory { get; set; }
    }
}
