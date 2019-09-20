using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Domain;
using CompanyName.MyMeetings.Modules.Administration.Domain.Users;

namespace CompanyName.MyMeetings.Modules.Administration.Domain.MeetingGroupProposals
{
    public class MeetingGroupProposalDecision : ValueObject
    {
        internal static MeetingGroupProposalDecision NoDecision =>
            new MeetingGroupProposalDecision(null, null, null, null);


        public DateTime? Date { get; }

        public UserId UserId { get; set; }

        public string Code { get; set; }

        public string RejectReason { get; set; }

        public MeetingGroupProposalDecision(DateTime? date, UserId userId, string code, string rejectReason)
        {
            Date = date;
            UserId = userId;
            Code = code;
            RejectReason = rejectReason;
        }

        internal static MeetingGroupProposalDecision AcceptDecision(DateTime date, UserId userId)
        {
            return new MeetingGroupProposalDecision(date, userId, "Accept", null);
        }

        internal static MeetingGroupProposalDecision RejectDecision(DateTime date, UserId userId, string rejectReason)
        {
            return new MeetingGroupProposalDecision(date, userId, "Reject", rejectReason);
        }

        internal MeetingGroupProposalStatus GetStatusForDecision()
        {
            if (this.IsAccepted)
            {
                return new MeetingGroupProposalStatus("Verified");
            }

            if (this.IsRejected)
            {
                return new MeetingGroupProposalStatus("Rejected");
            }

            return MeetingGroupProposalStatus.ToVerify;
        }



        private bool IsAccepted => this.Code == "Accept";

        private bool IsRejected => this.Code == "Reject";
    }
}
