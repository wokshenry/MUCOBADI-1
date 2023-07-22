using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ASubResults
    {
        public int SubResultId { get; set; }
        public int? ResultId { get; set; }
        public string SubResultDescription { get; set; }

        public virtual AResults Result { get; set; }
    }
}
