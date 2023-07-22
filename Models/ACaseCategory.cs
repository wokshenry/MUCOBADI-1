using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACaseCategory
    {
        public ACaseCategory()
        {
            ACaseCategoryItem = new HashSet<ACaseCategoryItem>();
        }

        public int CaseCategoryId { get; set; }
        public string CaseCategoryDesc { get; set; }

        public virtual ICollection<ACaseCategoryItem> ACaseCategoryItem { get; set; }
    }
}
