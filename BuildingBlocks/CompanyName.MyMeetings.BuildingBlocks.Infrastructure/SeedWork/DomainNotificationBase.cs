using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.BuildingBlocks.Infrastructure.SeedWork
{
    public class DomainNotificationBase<T> : IDomainEventNotification<T> where T:IDomainEvent
    {
        public Guid Id { get; }
        public T DomainEvent { get; }

        public DomainNotificationBase(T domainEvent)
        {
            this.Id = Guid.NewGuid();
            this.DomainEvent = domainEvent;
        }
    }
}
