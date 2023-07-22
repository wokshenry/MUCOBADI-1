using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class HouseHoldMembersLog
    {
        public double HouseHoldMemberLogId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? HouseHoldId { get; set; }
        public string ColumnEdited { get; set; }
        public string ActionTaken { get; set; }
        public string PreviousValue { get; set; }
        public string NewValue { get; set; }
        public string ActionMadeBy { get; set; }
        public DateTime? ActionDate { get; set; }
    }
}
