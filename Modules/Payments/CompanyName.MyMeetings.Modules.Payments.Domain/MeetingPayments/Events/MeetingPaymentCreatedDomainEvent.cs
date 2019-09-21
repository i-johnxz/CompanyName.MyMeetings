using CompanyName.MyMeetings.BuildingBlocks.Domain;
using CompanyName.MyMeetings.Modules.Payments.Domain.Payers;

namespace CompanyName.MyMeetings.Modules.Payments.Domain.MeetingPayments.Events
{
    public class MeetingPaymentCreatedDomainEvent : DomainEventBase
    {
        public MeetingPaymentCreatedDomainEvent(PayerId payerId, MeetingId meetingId, MoneyValue fee)
        {
            PayerId = payerId;
            MeetingId = meetingId;
            Fee = fee;
        }
        
        public PayerId PayerId { get; }

        public MeetingId MeetingId { get; }

        public MoneyValue Fee { get; }
    }
}