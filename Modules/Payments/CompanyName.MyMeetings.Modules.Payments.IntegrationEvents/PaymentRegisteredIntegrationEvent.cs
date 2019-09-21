using System;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.EventBus;

namespace CompanyName.MyMeetings.Modules.Payments.IntegrationEvents
{
    public class PaymentRegisteredIntegrationEvent : IntegrationEvent
    {
        public Guid MeetingGroupPaymentRegisterId { get; set; }

        public DateTime DateTo { get; set; }

        public PaymentRegisteredIntegrationEvent(
            Guid id, 
            DateTime occurredOn, 
            Guid meetingGroupPaymentRegisterId, 
            DateTime dateTo) : base(id, occurredOn)
        {
            MeetingGroupPaymentRegisterId = meetingGroupPaymentRegisterId;
            DateTo = dateTo;
        }
    }
}