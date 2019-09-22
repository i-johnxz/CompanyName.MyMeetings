using System;
using CompanyName.MyMeetings.Modules.Payments.Application.Configuration.Processing.InternalCommands;
using CompanyName.MyMeetings.Modules.Payments.Domain.MeetingPayments;
using CompanyName.MyMeetings.Modules.Payments.Domain.Payers;
using Newtonsoft.Json;

namespace CompanyName.MyMeetings.Modules.Payments.Application.MeetingPayments.CreateMeetingPayment
{
    internal class CreateMeetingPaymentCommand : InternalCommandBase
    {
        [JsonConstructor]
        public CreateMeetingPaymentCommand(
            Guid id, 
            PayerId payerId, 
            MeetingId meetingId,
            decimal value, 
            string currency) : base(id)
        {
            Value = value;
            Currency = currency;
            PayerId = payerId;
            MeetingId = meetingId;
        }
        
        internal decimal Value { get; }

        internal string Currency { get; }

        internal PayerId PayerId { get; }

        internal MeetingId MeetingId { get; }
    }
}