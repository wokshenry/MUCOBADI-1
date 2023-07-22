using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewAtrainingSession
    {
        public int SessionId { get; set; }
        public string SessionCategory { get; set; }
        public string SessionDesc { get; set; }
        public int CurriculumId { get; set; }
        public string CurriculumDesc { get; set; }
    }
}
