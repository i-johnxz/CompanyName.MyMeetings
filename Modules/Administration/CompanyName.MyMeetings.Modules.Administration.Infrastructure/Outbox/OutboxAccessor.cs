﻿using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Outbox;

namespace CompanyName.MyMeetings.Modules.Administration.Infrastructure.Outbox
{
    internal class OutboxAccessor : IOutbox
    {
        private readonly AdministrationContext _context;

        public OutboxAccessor(AdministrationContext context)
        {
            _context = context;
        }

        public void Add(OutboxMessage message)
        {
            _context.OutboxMessages.Add(message);
        }
    }
}
