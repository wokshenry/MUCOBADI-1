using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class GraduationBenchMarkDetail
    {
        public int GraduationBenchMarkDetailId { get; set; }
        public int? GraduationBenchMarkId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? IsHouseholdMemberActiveYesNo { get; set; }
        public string ReasonForInactiveHouseholdMember { get; set; }
        public int? MemberHivStatusDocumentYesNoId { get; set; }
        public int? PrimaryCareGiverHiveStatusDocumentedYesNoId { get; set; }
        public int? DocumentedAsVirallySuppressedYesNoId { get; set; }
        public int? RegularyAttendingArtAppointmentYesNoId { get; set; }
        public int? BeneficiariesbeentakingantiretroviraltherapypillsasprescribedYesNoId { get; set; }
        public int? AdolescentidentifiedatleasttwoHivrisksYesNoId { get; set; }
        public int? AdolescentidentifiedatleastoneHivpreventionstrategyYesNoId { get; set; }
        public int? ChildMuacmorethan125cmYesNoId { get; set; }
        public int? ChildfreeofanysignsofbipedaledemaYesNoId { get; set; }
        public int? RepeatedphysicalabuseYesNoId { get; set; }
        public int? SexuallyabusedYesNoId { get; set; }
        public int? HouseholdMembersbeenunderthecareofastableadultcaregiverYesNoId { get; set; }
        public int? AreenrolledinschoolYesNoId { get; set; }
        public int? AttendedschoolregularlyoverthepastyearYesNoId { get; set; }
        public int? ProgressedtonextclassfromlastyeartothisschoolyearYesNoId { get; set; }

        public virtual AYesNo AdolescentidentifiedatleastoneHivpreventionstrategyYesNo { get; set; }
        public virtual AYesNo AdolescentidentifiedatleasttwoHivrisksYesNo { get; set; }
        public virtual AYesNo AreenrolledinschoolYesNo { get; set; }
        public virtual AYesNo AttendedschoolregularlyoverthepastyearYesNo { get; set; }
        public virtual AYesNo BeneficiariesbeentakingantiretroviraltherapypillsasprescribedYesNo { get; set; }
        public virtual AYesNo ChildMuacmorethan125cmYesNo { get; set; }
        public virtual AYesNo ChildfreeofanysignsofbipedaledemaYesNo { get; set; }
        public virtual AYesNo DocumentedAsVirallySuppressedYesNo { get; set; }
        public virtual GraduationBenchMark GraduationBenchMark { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AYesNo HouseholdMembersbeenunderthecareofastableadultcaregiverYesNo { get; set; }
        public virtual AYesNo IsHouseholdMemberActiveYesNoNavigation { get; set; }
        public virtual AYesNo MemberHivStatusDocumentYesNo { get; set; }
        public virtual AYesNo PrimaryCareGiverHiveStatusDocumentedYesNo { get; set; }
        public virtual AYesNo ProgressedtonextclassfromlastyeartothisschoolyearYesNo { get; set; }
        public virtual AYesNo RegularyAttendingArtAppointmentYesNo { get; set; }
        public virtual AYesNo RepeatedphysicalabuseYesNo { get; set; }
        public virtual AYesNo SexuallyabusedYesNo { get; set; }
    }
}
