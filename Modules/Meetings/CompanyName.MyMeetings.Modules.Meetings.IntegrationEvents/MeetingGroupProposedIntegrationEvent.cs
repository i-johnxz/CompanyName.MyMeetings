using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.EventBus;

namespace CompanyName.MyMeetings.Modules.Meetings.IntegrationEvents
{
    public class MeetingGroupProposedIntegrationEvent : IntegrationEvent
    {
        public Guid MeetingGroupProposalId { get; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string LocationCity { get; set; }

        public string LocationCountryCode { get; set; }


        public Guid ProposalUserId { get; set; }

        public DateTime ProposalDate { get; set; }


        public MeetingGroupProposedIntegrationEvent(
            Guid id, 
            DateTime occurredOn, 
            Guid meetingGroupProposalId, 
            string name, 
            string description, 
            string locationCity, 
            string locationCountryCode, 
            Guid proposalUserId, 
            DateTime proposalDate) 
            : base(id, occurredOn)
        {
            MeetingGroupProposalId = meetingGroupProposalId;
            Name = name;
            Description = description;
            LocationCity = locationCity;
            LocationCountryCode = locationCountryCode;
            ProposalUserId = proposalUserId;
            ProposalDate = proposalDate;
        }
    }
}
