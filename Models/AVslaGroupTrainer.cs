using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AVslaGroupTrainer
    {
        public AVslaGroupTrainer()
        {
            VslaTrackingTool = new HashSet<VslaTrackingTool>();
        }

        public int VslaGroupTrainerId { get; set; }
        public string VslaGroupTrainerDesc { get; set; }

        public virtual ICollection<VslaTrackingTool> VslaTrackingTool { get; set; }
    }
}
