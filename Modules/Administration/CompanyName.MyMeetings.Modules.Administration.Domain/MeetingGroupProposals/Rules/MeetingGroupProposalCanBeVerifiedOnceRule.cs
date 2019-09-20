using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.Administration.Domain.MeetingGroupProposals.Rules
{
    public class MeetingGroupProposalCanBeVerifiedOnceRule : IBusinessRule
    {

        private readonly MeetingGroupProposalDecision _actualDecision;

        public MeetingGroupProposalCanBeVerifiedOnceRule(MeetingGroupProposalDecision actualDecision)
        {
            _actualDecision = actualDecision;
        }


        public bool IsBroken() => _actualDecision != MeetingGroupProposalDecision.NoDecision;

        public string Message => "Meeting group proposal can be verified only once";
    }
}
