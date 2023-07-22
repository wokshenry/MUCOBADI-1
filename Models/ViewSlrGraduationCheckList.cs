using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewSlrGraduationCheckList
    {
        public int GraduationChecklistId { get; set; }
        public int HouseHoldId { get; set; }
        public int HouseHoldMemberId { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public int? YesCount { get; set; }
        public int? Nacount { get; set; }
    }
}
