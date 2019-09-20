using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.EventBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.Modules.Administration.IntegrationEvents
{
    public class MeetingGroupProposalAcceptedIntegrationEvent : IntegrationEvent
    {
        public MeetingGroupProposalAcceptedIntegrationEvent(
            Guid id, 
            DateTime occurredOn, 
            Guid meetingGroupProposalId) : base(id, occurredOn)
        {
            MeetingGroupProposalId = meetingGroupProposalId;
        }

        public Guid MeetingGroupProposalId { get; }
    }
}
