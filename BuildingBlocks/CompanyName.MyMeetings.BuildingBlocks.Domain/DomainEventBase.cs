using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.BuildingBlocks.Domain
{
    public class DomainEventBase : IDomainEvent
    {
        public DateTime OccurredOn { get; }

        public DomainEventBase()
        {
            this.OccurredOn = DateTime.UtcNow;
        }
    }
}
