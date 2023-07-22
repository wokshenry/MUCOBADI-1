using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AResults
    {
        public AResults()
        {
            ASubResults = new HashSet<ASubResults>();
        }

        public int ResultId { get; set; }
        public string ResultDescription { get; set; }

        public virtual ICollection<ASubResults> ASubResults { get; set; }
    }
}
