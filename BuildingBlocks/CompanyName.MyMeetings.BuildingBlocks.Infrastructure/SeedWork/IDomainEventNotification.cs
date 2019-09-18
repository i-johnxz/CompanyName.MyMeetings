using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CompanyName.MyMeetings.BuildingBlocks.Infrastructure.SeedWork
{
    public interface IDomainEventNotification<out TEventType> : IDomainEventNotification
    {
        TEventType DomainEvent { get; }
    }

    public interface IDomainEventNotification : INotification
    {
        Guid Id { get; }
    }
}
