using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CompanyName.MyMeetings.BuildingBlocks.Domain
{
    public interface IDomainEvent : INotification
    {
        DateTime OccurredOn { get; }
    }
}
