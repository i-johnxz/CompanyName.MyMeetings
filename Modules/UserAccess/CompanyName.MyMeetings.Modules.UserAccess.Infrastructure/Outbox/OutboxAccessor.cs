﻿using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Outbox;

namespace CompanyName.MyMeetings.Modules.UserAccess.Infrastructure.Outbox
{
    public class OutboxAccessor : IOutbox
    {
        private readonly UserAccessContext _userAccessContext;

        public OutboxAccessor(UserAccessContext userAccessContext)
        {
            _userAccessContext = userAccessContext;
        }

        public void Add(OutboxMessage message)
        {
            _userAccessContext.OutboxMessages.Add(message);
        }
    }
}
