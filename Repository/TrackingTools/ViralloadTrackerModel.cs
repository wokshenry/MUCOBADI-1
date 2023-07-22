using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MUCOBADI.Repository.TrackingTools
{
    public class ViralloadTrackerModel
    {
        public void ForwardValidViralload()
        {
            try
            {
                using (MUCOBADIContext db = new MUCOBADIContext())
                {

                    var CurrentDate = DateTime.Now;
                    var validViraload = db.HivTbTrackingForm.Where(o => o.NextViralloadTestDate >= CurrentDate).ToList();
                    //Quarter 2
                    QuarterTwoDue(validViraload);
                    //Quarter 3
                    QuarterThreeDue(validViraload);
                    //Quarter 4
                    QuarterFourDue(validViraload);
                    //Quarter 1
                    QuarterOneDue(validViraload);





                    //if (CurrentDate.Month == 1 && CurrentDate.Day == 1)
                    //{
                    //    DateTime QuarterDate = new DateTime(DateTime.Now.Year, 1, 1);
                    //    foreach (var n in validViraload)
                    //    {
                    //        var exists = db.HivTbTrackingForm.FirstOrDefault(o => o.FollowUpDate == QuarterDate && o.HouseHoldMemberId == n.HouseHoldMemberId);
                    //        if (exists == null)
                    //        {
                    //            int id = 1;
                    //            var last = db.HivTbTrackingForm.OrderBy(o => o.HivTbTrackingFormId).ToList().LastOrDefault();
                    //            if (last != null)
                    //            {
                    //                id = (last.HivTbTrackingFormId + 1);
                    //            }
                    //            n.HivTbTrackingFormId = id;
                    //            n.FollowUpDate = QuarterDate;
                    //            db.HivTbTrackingForm.Add(n);
                    //            db.SaveChanges();
                    //        }
                    //    }
                    //}
                    //else if (CurrentDate.Month == 4 && CurrentDate.Day == 1)
                    //{
                    //    DateTime QuarterDate = new DateTime(DateTime.Now.Year, 4, 1);
                    //    foreach (var n in validViraload)
                    //    {
                    //        var exists = db.HivTbTrackingForm.FirstOrDefault(o => o.FollowUpDate == QuarterDate && o.HouseHoldMemberId == n.HouseHoldMemberId);
                    //        if (exists == null)
                    //        {
                    //            int id = 1;
                    //            var last = db.HivTbTrackingForm.OrderBy(o => o.HivTbTrackingFormId).ToList().LastOrDefault();
                    //            if (last != null)
                    //            {
                    //                id = (last.HivTbTrackingFormId + 1);
                    //            }
                    //            n.HivTbTrackingFormId = id;
                    //            n.FollowUpDate = QuarterDate;
                    //            db.HivTbTrackingForm.Add(n);
                    //            db.SaveChanges();
                    //        }
                    //    }
                    //}
                    //else if (CurrentDate.Month == 7 && CurrentDate.Day == 1)
                    //{
                    //    DateTime QuarterDate = new DateTime(DateTime.Now.Year, 7, 1);
                    //    foreach (var n in validViraload)
                    //    {
                    //        var exists = db.HivTbTrackingForm.FirstOrDefault(o => o.FollowUpDate == QuarterDate && o.HouseHoldMemberId == n.HouseHoldMemberId);
                    //        if (exists == null)
                    //        {
                    //            int id = 1;
                    //            var last = db.HivTbTrackingForm.OrderBy(o => o.HivTbTrackingFormId).ToList().LastOrDefault();
                    //            if (last != null)
                    //            {
                    //                id = (last.HivTbTrackingFormId + 1);
                    //            }
                    //            n.HivTbTrackingFormId = id;
                    //            n.FollowUpDate = QuarterDate;
                    //            db.HivTbTrackingForm.Add(n);
                    //            db.SaveChanges();
                    //        }
                    //    }
                    //}
                    //else if (CurrentDate.Month == 10 && CurrentDate.Day == 1)
                    //{
                    //    DateTime QuarterDate = new DateTime(DateTime.Now.Year, 10, 1);
                    //    foreach (var n in validViraload)
                    //    {
                    //        var exists = db.HivTbTrackingForm.FirstOrDefault(o => o.FollowUpDate == QuarterDate && o.HouseHoldMemberId == n.HouseHoldMemberId);
                    //        if (exists == null)
                    //        {
                    //            int id = 1;
                    //            var last = db.HivTbTrackingForm.OrderBy(o => o.HivTbTrackingFormId).ToList().LastOrDefault();
                    //            if (last != null)
                    //            {
                    //                id = (last.HivTbTrackingFormId + 1);
                    //            }
                    //            n.HivTbTrackingFormId = id;
                    //            n.FollowUpDate = QuarterDate;
                    //            db.HivTbTrackingForm.Add(n);
                    //            db.SaveChanges();
                    //        }
                    //    }
                    //} 
                }

            }
            catch (System.Exception ex)
            {

                //throw;
            }
        }

        private void QuarterTwoDue(List<HivTbTrackingForm> data)
        {
            DateTime Startdate = new DateTime(DateTime.Now.Year,1,1);
            DateTime Enddate = new DateTime(DateTime.Now.Year, Startdate.AddMonths(2).Month, DateTime.DaysInMonth(DateTime.Now.Year,Startdate.AddMonths(2).Month));
            var EligiblethatQuater = data.Where(o => o.NextViralloadTestDate >= Startdate && o.NextViralloadTestDate <= Enddate).ToList();
            if(EligiblethatQuater!= null && EligiblethatQuater.Count > 0)
            {
                using (MUCOBADIContext db = new MUCOBADIContext())
                {
                    foreach (var n in EligiblethatQuater)
                    {
                        var exists = db.HivTbTrackingForm.FirstOrDefault(o => o.FollowUpDate == Startdate && o.HouseHoldMemberId == n.HouseHoldMemberId);
                        if (exists == null)
                        {
                            int id = 1;
                            var last = db.HivTbTrackingForm.OrderBy(o => o.HivTbTrackingFormId).ToList().LastOrDefault();
                            if (last != null)
                            {
                                id = (last.HivTbTrackingFormId + 1);
                            }
                            HivTbTrackingForm m = new();
                            m.HivTbTrackingFormId = id;
                            m.HouseHoldMemberId = n.HouseHoldMemberId;
                            m.FollowUpDate = Startdate;

                            m.HivstatusId = n.HivstatusId;
                            m.OnArt = n.OnArt;
                            m.Artnumber = n.Artnumber;
                            m.CohortNo = n.CohortNo;
                            m.ClientMemberStatusId = n.ClientMemberStatusId;
                            m.ClientMemberStatusOther = n.ClientMemberStatusOther;
                            m.CientClassificationId = n.CientClassificationId;
                            m.Weight = n.Weight;
                            m.FacilityId = n.FacilityId;
                            m.TreatmentDuration = n.TreatmentDuration;
                            m.RegimenCategoryId = n.RegimenCategoryId;
                            m.RegimenId = n.RegimenId;
                            m.ClientCareModalityId = n.ClientCareModalityId;
                            m.ClientCareModalityIdOther = n.ClientCareModalityIdOther;
                            m.DrugDispensingModalityId = n.DrugDispensingModalityId;
                            m.CurrentCarePointSubCountyId = n.CurrentCarePointSubCountyId;
                            m.CurrentCarePointDistrictId = n.CurrentCarePointDistrictId;
                            m.LastAppointmentDate = n.LastAppointmentDate;
                            m.NextAppointmentDate = n.NextAppointmentDate;
                            m.IsClientEligibleForViralload = n.IsClientEligibleForViralload;
                            m.ViralloadTestDone = n.ViralloadTestDone;
                            m.ViralloadResultsReceived = n.ViralloadResultsReceived;
                            m.ViralloadTestResults = n.ViralloadTestResults;
                            m.ViralLoadSuppressedId = n.ViralLoadSuppressedId;
                            m.LastViralloadTestDate = n.LastViralloadTestDate;
                            m.NextViralloadTestDate = n.NextViralloadTestDate;
                            m.ClientHasPresumptiveOrActiveTb = n.ClientHasPresumptiveOrActiveTb;
                            m.ClientReceivedTbscreeningSession = n.ClientReceivedTbscreeningSession;
                            m.ClientAtTbinfectionRisk = n.ClientAtTbinfectionRisk;
                            m.ClientRefferedTestedForTb = n.ClientRefferedTestedForTb;
                            m.TbtestResultId = n.TbtestResultId;
                            m.IsOnTbtreatment = n.IsOnTbtreatment;
                            m.TbtreatmentDuration = n.TbtreatmentDuration;
                            m.IsOnTbpreventiveTreatment = n.IsOnTbpreventiveTreatment;
                            m.TptTreatmentDuration = n.TptTreatmentDuration;
                            m.FollowupMeansId = n.FollowupMeansId;
                            m.ClientSuccessfullyContactedOrSeen = n.ClientSuccessfullyContactedOrSeen;
                            m.AnotherPersonContactedOnBehalfOfClient = n.AnotherPersonContactedOnBehalfOfClient;
                            m.PersonContactedId = n.PersonContactedId;
                            m.OtherPersonContacted = n.OtherPersonContacted;
                            m.ServiceProvidedId = n.ServiceProvidedId;
                            m.OtherServiceProvided = n.OtherServiceProvided;
                            m.NotSuppressingReasonId = n.NotSuppressingReasonId;
                            m.OtherNotSuppressingReason = n.OtherNotSuppressingReason;
                            m.NonAdherenceId = n.NonAdherenceId;
                            m.NonAdherenceOther = n.NonAdherenceOther;
                            m.SocialWorkerNextActionTaken = n.SocialWorkerNextActionTaken;
                            m.SocialWorkerName = n.SocialWorkerName;
                            m.SocialWorkerTitle = n.SocialWorkerTitle;
                            m.SocialWorkerContact = n.SocialWorkerContact;
                            m.SocialWorkerEntryDate = n.SocialWorkerEntryDate;
                            m.ReviewedBy = n.ReviewedBy;
                            m.ReviewedTitle = n.ReviewedTitle;
                            m.ReviewedContact = n.ReviewedContact;
                            m.ReviewDate = n.ReviewDate;
                            m.PhoneNumber = n.PhoneNumber;

                            db.HivTbTrackingForm.Add(m);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
        private void QuarterThreeDue(List<HivTbTrackingForm> data)
        {
            DateTime Startdate = new DateTime(DateTime.Now.Year, 4, 1);
            DateTime Enddate = new DateTime(DateTime.Now.Year, Startdate.AddMonths(2).Month, DateTime.DaysInMonth(DateTime.Now.Year, Startdate.AddMonths(2).Month));
            var EligiblethatQuater = data.Where(o => o.NextViralloadTestDate >= Startdate && o.NextViralloadTestDate <= Enddate).ToList();
            if (EligiblethatQuater != null && EligiblethatQuater.Count > 0)
            {
                using (MUCOBADIContext db = new MUCOBADIContext())
                {
                    foreach (var n in EligiblethatQuater)
                    {
                        var exists = db.HivTbTrackingForm.FirstOrDefault(o => o.FollowUpDate == Startdate && o.HouseHoldMemberId == n.HouseHoldMemberId);
                        if (exists == null)
                        {
                            int id = 1;
                            var last = db.HivTbTrackingForm.OrderBy(o => o.HivTbTrackingFormId).ToList().LastOrDefault();
                            if (last != null)
                            {
                                id = (last.HivTbTrackingFormId + 1);
                            }
                            HivTbTrackingForm m = new();
                            m.HivTbTrackingFormId = id;
                            m.HouseHoldMemberId = n.HouseHoldMemberId;
                            m.FollowUpDate = Startdate;
                            m.HivstatusId = n.HivstatusId;
                            m.OnArt = n.OnArt;
                            m.Artnumber = n.Artnumber;
                            m.CohortNo = n.CohortNo;
                            m.ClientMemberStatusId = n.ClientMemberStatusId;
                            m.ClientMemberStatusOther = n.ClientMemberStatusOther;
                            m.CientClassificationId = n.CientClassificationId;
                            m.Weight = n.Weight;
                            m.FacilityId = n.FacilityId;
                            m.TreatmentDuration = n.TreatmentDuration;
                            m.RegimenCategoryId = n.RegimenCategoryId;
                            m.RegimenId = n.RegimenId;
                            m.ClientCareModalityId = n.ClientCareModalityId;
                            m.ClientCareModalityIdOther = n.ClientCareModalityIdOther;
                            m.DrugDispensingModalityId = n.DrugDispensingModalityId;
                            m.CurrentCarePointSubCountyId = n.CurrentCarePointSubCountyId;
                            m.CurrentCarePointDistrictId = n.CurrentCarePointDistrictId;
                            m.LastAppointmentDate = n.LastAppointmentDate;
                            m.NextAppointmentDate = n.NextAppointmentDate;
                            m.IsClientEligibleForViralload = n.IsClientEligibleForViralload;
                            m.ViralloadTestDone = n.ViralloadTestDone;
                            m.ViralloadResultsReceived = n.ViralloadResultsReceived;
                            m.ViralloadTestResults = n.ViralloadTestResults;
                            m.ViralLoadSuppressedId = n.ViralLoadSuppressedId;
                            m.LastViralloadTestDate = n.LastViralloadTestDate;
                            m.NextViralloadTestDate = n.NextViralloadTestDate;
                            m.ClientHasPresumptiveOrActiveTb = n.ClientHasPresumptiveOrActiveTb;
                            m.ClientReceivedTbscreeningSession = n.ClientReceivedTbscreeningSession;
                            m.ClientAtTbinfectionRisk = n.ClientAtTbinfectionRisk;
                            m.ClientRefferedTestedForTb = n.ClientRefferedTestedForTb;
                            m.TbtestResultId = n.TbtestResultId;
                            m.IsOnTbtreatment = n.IsOnTbtreatment;
                            m.TbtreatmentDuration = n.TbtreatmentDuration;
                            m.IsOnTbpreventiveTreatment = n.IsOnTbpreventiveTreatment;
                            m.TptTreatmentDuration = n.TptTreatmentDuration;
                            m.FollowupMeansId = n.FollowupMeansId;
                            m.ClientSuccessfullyContactedOrSeen = n.ClientSuccessfullyContactedOrSeen;
                            m.AnotherPersonContactedOnBehalfOfClient = n.AnotherPersonContactedOnBehalfOfClient;
                            m.PersonContactedId = n.PersonContactedId;
                            m.OtherPersonContacted = n.OtherPersonContacted;
                            m.ServiceProvidedId = n.ServiceProvidedId;
                            m.OtherServiceProvided = n.OtherServiceProvided;
                            m.NotSuppressingReasonId = n.NotSuppressingReasonId;
                            m.OtherNotSuppressingReason = n.OtherNotSuppressingReason;
                            m.NonAdherenceId = n.NonAdherenceId;
                            m.NonAdherenceOther = n.NonAdherenceOther;
                            m.SocialWorkerNextActionTaken = n.SocialWorkerNextActionTaken;
                            m.SocialWorkerName = n.SocialWorkerName;
                            m.SocialWorkerTitle = n.SocialWorkerTitle;
                            m.SocialWorkerContact = n.SocialWorkerContact;
                            m.SocialWorkerEntryDate = n.SocialWorkerEntryDate;
                            m.ReviewedBy = n.ReviewedBy;
                            m.ReviewedTitle = n.ReviewedTitle;
                            m.ReviewedContact = n.ReviewedContact;
                            m.ReviewDate = n.ReviewDate;
                            m.PhoneNumber = n.PhoneNumber;

                            db.HivTbTrackingForm.Add(m);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
        private void QuarterFourDue(List<HivTbTrackingForm> data)
        {
            DateTime Startdate = new DateTime(DateTime.Now.Year, 7, 1);
            DateTime Enddate = new DateTime(DateTime.Now.Year, Startdate.AddMonths(2).Month, DateTime.DaysInMonth(DateTime.Now.Year, Startdate.AddMonths(2).Month));
            var EligiblethatQuater = data.Where(o => o.NextViralloadTestDate >= Startdate && o.NextViralloadTestDate <= Enddate).ToList();
            if (EligiblethatQuater != null && EligiblethatQuater.Count > 0)
            {
                using (MUCOBADIContext db = new MUCOBADIContext())
                {
                    foreach (var n in EligiblethatQuater)
                    {
                        var exists = db.HivTbTrackingForm.FirstOrDefault(o => o.FollowUpDate == Startdate && o.HouseHoldMemberId == n.HouseHoldMemberId);
                        if (exists == null)
                        {
                            int id = 1;
                            var last = db.HivTbTrackingForm.OrderBy(o => o.HivTbTrackingFormId).ToList().LastOrDefault();
                            if (last != null)
                            {
                                id = (last.HivTbTrackingFormId + 1);
                            }
                            HivTbTrackingForm m = new();
                            m.HivTbTrackingFormId = id;
                            m.HouseHoldMemberId = n.HouseHoldMemberId;
                            m.FollowUpDate = Startdate;

                            m.HivstatusId = n.HivstatusId;
                            m.OnArt = n.OnArt;
                            m.Artnumber = n.Artnumber;
                            m.CohortNo = n.CohortNo;
                            m.ClientMemberStatusId = n.ClientMemberStatusId;
                            m.ClientMemberStatusOther = n.ClientMemberStatusOther;
                            m.CientClassificationId = n.CientClassificationId;
                            m.Weight = n.Weight;
                            m.FacilityId = n.FacilityId;
                            m.TreatmentDuration = n.TreatmentDuration;
                            m.RegimenCategoryId = n.RegimenCategoryId;
                            m.RegimenId = n.RegimenId;
                            m.ClientCareModalityId = n.ClientCareModalityId;
                            m.ClientCareModalityIdOther = n.ClientCareModalityIdOther;
                            m.DrugDispensingModalityId = n.DrugDispensingModalityId;
                            m.CurrentCarePointSubCountyId = n.CurrentCarePointSubCountyId;
                            m.CurrentCarePointDistrictId = n.CurrentCarePointDistrictId;
                            m.LastAppointmentDate = n.LastAppointmentDate;
                            m.NextAppointmentDate = n.NextAppointmentDate;
                            m.IsClientEligibleForViralload = n.IsClientEligibleForViralload;
                            m.ViralloadTestDone = n.ViralloadTestDone;
                            m.ViralloadResultsReceived = n.ViralloadResultsReceived;
                            m.ViralloadTestResults = n.ViralloadTestResults;
                            m.ViralLoadSuppressedId = n.ViralLoadSuppressedId;
                            m.LastViralloadTestDate = n.LastViralloadTestDate;
                            m.NextViralloadTestDate = n.NextViralloadTestDate;
                            m.ClientHasPresumptiveOrActiveTb = n.ClientHasPresumptiveOrActiveTb;
                            m.ClientReceivedTbscreeningSession = n.ClientReceivedTbscreeningSession;
                            m.ClientAtTbinfectionRisk = n.ClientAtTbinfectionRisk;
                            m.ClientRefferedTestedForTb = n.ClientRefferedTestedForTb;
                            m.TbtestResultId = n.TbtestResultId;
                            m.IsOnTbtreatment = n.IsOnTbtreatment;
                            m.TbtreatmentDuration = n.TbtreatmentDuration;
                            m.IsOnTbpreventiveTreatment = n.IsOnTbpreventiveTreatment;
                            m.TptTreatmentDuration = n.TptTreatmentDuration;
                            m.FollowupMeansId = n.FollowupMeansId;
                            m.ClientSuccessfullyContactedOrSeen = n.ClientSuccessfullyContactedOrSeen;
                            m.AnotherPersonContactedOnBehalfOfClient = n.AnotherPersonContactedOnBehalfOfClient;
                            m.PersonContactedId = n.PersonContactedId;
                            m.OtherPersonContacted = n.OtherPersonContacted;
                            m.ServiceProvidedId = n.ServiceProvidedId;
                            m.OtherServiceProvided = n.OtherServiceProvided;
                            m.NotSuppressingReasonId = n.NotSuppressingReasonId;
                            m.OtherNotSuppressingReason = n.OtherNotSuppressingReason;
                            m.NonAdherenceId = n.NonAdherenceId;
                            m.NonAdherenceOther = n.NonAdherenceOther;
                            m.SocialWorkerNextActionTaken = n.SocialWorkerNextActionTaken;
                            m.SocialWorkerName = n.SocialWorkerName;
                            m.SocialWorkerTitle = n.SocialWorkerTitle;
                            m.SocialWorkerContact = n.SocialWorkerContact;
                            m.SocialWorkerEntryDate = n.SocialWorkerEntryDate;
                            m.ReviewedBy = n.ReviewedBy;
                            m.ReviewedTitle = n.ReviewedTitle;
                            m.ReviewedContact = n.ReviewedContact;
                            m.ReviewDate = n.ReviewDate;
                            m.PhoneNumber = n.PhoneNumber;

                            db.HivTbTrackingForm.Add(m);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
        private void QuarterOneDue(List<HivTbTrackingForm> data)
        {
            DateTime Startdate = new DateTime(DateTime.Now.Year, 10, 1);
            DateTime Enddate = new DateTime(DateTime.Now.Year, Startdate.AddMonths(2).Month, DateTime.DaysInMonth(DateTime.Now.Year, Startdate.AddMonths(2).Month));
            var EligiblethatQuater = data.Where(o => o.NextViralloadTestDate >= Startdate && o.NextViralloadTestDate <= Enddate).ToList();
            if (EligiblethatQuater != null && EligiblethatQuater.Count > 0)
            {
                using (MUCOBADIContext db = new MUCOBADIContext())
                {
                    foreach (var n in EligiblethatQuater)
                    {
                        var exists = db.HivTbTrackingForm.FirstOrDefault(o => o.FollowUpDate == Startdate && o.HouseHoldMemberId == n.HouseHoldMemberId);
                        if (exists == null)
                        {
                            int id = 1;
                            var last = db.HivTbTrackingForm.OrderBy(o => o.HivTbTrackingFormId).ToList().LastOrDefault();
                            if (last != null)
                            {
                                id = (last.HivTbTrackingFormId + 1);
                            }

                            HivTbTrackingForm m = new();
                            m.HivTbTrackingFormId = id;
                            m.HouseHoldMemberId = n.HouseHoldMemberId;
                            m.FollowUpDate = Startdate;
                            m.HivstatusId = n.HivstatusId;
                            m.OnArt = n.OnArt;
                            m.Artnumber = n.Artnumber;
                            m.CohortNo = n.CohortNo;
                            m.ClientMemberStatusId = n.ClientMemberStatusId;
                            m.ClientMemberStatusOther = n.ClientMemberStatusOther;
                            m.CientClassificationId = n.CientClassificationId;
                            m.Weight = n.Weight;
                            m.FacilityId = n.FacilityId;
                            m.TreatmentDuration = n.TreatmentDuration;
                            m.RegimenCategoryId = n.RegimenCategoryId;
                            m.RegimenId = n.RegimenId;
                            m.ClientCareModalityId = n.ClientCareModalityId;
                            m.ClientCareModalityIdOther = n.ClientCareModalityIdOther;
                            m.DrugDispensingModalityId = n.DrugDispensingModalityId;
                            m.CurrentCarePointSubCountyId = n.CurrentCarePointSubCountyId;
                            m.CurrentCarePointDistrictId = n.CurrentCarePointDistrictId;
                            m.LastAppointmentDate = n.LastAppointmentDate;
                            m.NextAppointmentDate = n.NextAppointmentDate;
                            m.IsClientEligibleForViralload = n.IsClientEligibleForViralload;
                            m.ViralloadTestDone = n.ViralloadTestDone;
                            m.ViralloadResultsReceived = n.ViralloadResultsReceived;
                            m.ViralloadTestResults = n.ViralloadTestResults;
                            m.ViralLoadSuppressedId = n.ViralLoadSuppressedId;
                            m.LastViralloadTestDate = n.LastViralloadTestDate;
                            m.NextViralloadTestDate = n.NextViralloadTestDate;
                            m.ClientHasPresumptiveOrActiveTb = n.ClientHasPresumptiveOrActiveTb;
                            m.ClientReceivedTbscreeningSession = n.ClientReceivedTbscreeningSession;
                            m.ClientAtTbinfectionRisk = n.ClientAtTbinfectionRisk;
                            m.ClientRefferedTestedForTb = n.ClientRefferedTestedForTb;
                            m.TbtestResultId = n.TbtestResultId;
                            m.IsOnTbtreatment = n.IsOnTbtreatment;
                            m.TbtreatmentDuration = n.TbtreatmentDuration;
                            m.IsOnTbpreventiveTreatment = n.IsOnTbpreventiveTreatment;
                            m.TptTreatmentDuration = n.TptTreatmentDuration;
                            m.FollowupMeansId = n.FollowupMeansId;
                            m.ClientSuccessfullyContactedOrSeen = n.ClientSuccessfullyContactedOrSeen;
                            m.AnotherPersonContactedOnBehalfOfClient = n.AnotherPersonContactedOnBehalfOfClient;
                            m.PersonContactedId = n.PersonContactedId;
                            m.OtherPersonContacted = n.OtherPersonContacted;
                            m.ServiceProvidedId = n.ServiceProvidedId;
                            m.OtherServiceProvided = n.OtherServiceProvided;
                            m.NotSuppressingReasonId = n.NotSuppressingReasonId;
                            m.OtherNotSuppressingReason = n.OtherNotSuppressingReason;
                            m.NonAdherenceId = n.NonAdherenceId;
                            m.NonAdherenceOther = n.NonAdherenceOther;
                            m.SocialWorkerNextActionTaken = n.SocialWorkerNextActionTaken;
                            m.SocialWorkerName = n.SocialWorkerName;
                            m.SocialWorkerTitle = n.SocialWorkerTitle;
                            m.SocialWorkerContact = n.SocialWorkerContact;
                            m.SocialWorkerEntryDate = n.SocialWorkerEntryDate;
                            m.ReviewedBy = n.ReviewedBy;
                            m.ReviewedTitle = n.ReviewedTitle;
                            m.ReviewedContact = n.ReviewedContact;
                            m.ReviewDate = n.ReviewDate;
                            m.PhoneNumber = n.PhoneNumber;

                            db.HivTbTrackingForm.Add(m);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}
