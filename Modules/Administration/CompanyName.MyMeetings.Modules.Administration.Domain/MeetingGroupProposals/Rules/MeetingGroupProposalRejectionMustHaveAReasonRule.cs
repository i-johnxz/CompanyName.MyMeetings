using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.Administration.Domain.MeetingGroupProposals.Rules
{
    public class MeetingGroupProposalRejectionMustHaveAReasonRule : IBusinessRule
    {

        private readonly string _reason;

        public MeetingGroupProposalRejectionMustHaveAReasonRule(string reason)
        {
            _reason = reason;
        }


        public bool IsBroken() => string.IsNullOrWhiteSpace(_reason);

        public string Message => "Meeting group proposal rejection must have a reason";
    }
}
