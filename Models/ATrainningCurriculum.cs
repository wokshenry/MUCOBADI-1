using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATrainningCurriculum
    {
        public ATrainningCurriculum()
        {
            ATrainingSession = new HashSet<ATrainingSession>();
            CommunityTrainingRegister = new HashSet<CommunityTrainingRegister>();
        }

        public int CurriculumId { get; set; }
        public string CurriculumDesc { get; set; }

        public virtual ICollection<ATrainingSession> ATrainingSession { get; set; }
        public virtual ICollection<CommunityTrainingRegister> CommunityTrainingRegister { get; set; }
    }
}
