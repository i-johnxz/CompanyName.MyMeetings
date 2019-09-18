using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Outbox
{
    public interface IOutbox
    {
        void Add(OutboxMessage message);
    }
}
