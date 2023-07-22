using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATrainingSession
    {
        public ATrainingSession()
        {
            CommunityTrainingRegisterDirectMember = new HashSet<CommunityTrainingRegisterDirectMember>();
            CommunityTrainingRegisterIndirectMember = new HashSet<CommunityTrainingRegisterIndirectMember>();
        }

        public int SessionId { get; set; }
        public int? CurriculumId { get; set; }
        public string SessionCategory { get; set; }
        public string SessionDesc { get; set; }

        public virtual ATrainningCurriculum Curriculum { get; set; }
        public virtual ICollection<CommunityTrainingRegisterDirectMember> CommunityTrainingRegisterDirectMember { get; set; }
        public virtual ICollection<CommunityTrainingRegisterIndirectMember> CommunityTrainingRegisterIndirectMember { get; set; }
    }
}
