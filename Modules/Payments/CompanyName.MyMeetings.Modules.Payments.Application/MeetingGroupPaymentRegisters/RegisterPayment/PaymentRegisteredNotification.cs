﻿using System;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.SeedWork;
using CompanyName.MyMeetings.Modules.Payments.Domain.MeetingGroupPaymentRegisters;
using CompanyName.MyMeetings.Modules.Payments.Domain.MeetingGroupPaymentRegisters.Events;

namespace CompanyName.MyMeetings.Modules.Payments.Application.MeetingGroupPaymentRegisters.RegisterPayment
{
    public class PaymentRegisteredNotification : DomainNotificationBase<PaymentRegisteredDomainEvent>
    {
        public PaymentRegisteredNotification(PaymentRegisteredDomainEvent domainEvent, MeetingGroupPaymentRegisterId meetingGroupPaymentRegisterId, DateTime dateTo) : base(domainEvent)
        {
            MeetingGroupPaymentRegisterId = meetingGroupPaymentRegisterId;
            DateTo = dateTo;
        }
        
        public MeetingGroupPaymentRegisterId MeetingGroupPaymentRegisterId { get; }

        public DateTime DateTo { get; set; }
        
        
    }
}