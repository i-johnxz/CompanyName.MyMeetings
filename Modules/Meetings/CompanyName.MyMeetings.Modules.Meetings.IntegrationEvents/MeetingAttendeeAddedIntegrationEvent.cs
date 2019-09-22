using System;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.EventBus;

namespace CompanyName.MyMeetings.Modules.Meetings.IntegrationEvents
{
    public class MeetingAttendeeAddedIntegrationEvent : IntegrationEvent
    {
        public Guid MeetingId { get; }

        public Guid AttendeeId { get; set; }

        public decimal? FeeValue { get; set; }

        public string FeeCurrency { get; set; }

        public MeetingAttendeeAddedIntegrationEvent(
            Guid id, DateTime occurredOn, Guid meetingId, 
            Guid attendeeId, decimal? feeValue, string feeCurrency) : base(id, occurredOn)
        {
            MeetingId = meetingId;
            AttendeeId = attendeeId;
            FeeValue = feeValue;
            FeeCurrency = feeCurrency;
        }
        
    }
}