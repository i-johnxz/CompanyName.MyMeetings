using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.Administration.Domain.MeetingGroupProposals
{
    public class MeetingGroupProposalStatus : ValueObject
    {
        internal static MeetingGroupProposalStatus ToVerify => new MeetingGroupProposalStatus("ToVerify");

        public string Value { get; }

        internal MeetingGroupProposalStatus(string value)
        {
            Value = value;
        }
    }
}
