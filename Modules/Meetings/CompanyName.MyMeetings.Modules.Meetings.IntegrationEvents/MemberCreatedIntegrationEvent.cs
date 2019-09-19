﻿using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.EventBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.Modules.Meetings.IntegrationEvents
{
    public class MemberCreatedIntegrationEvent : IntegrationEvent
    {
        public Guid MemberId { get; }

        public MemberCreatedIntegrationEvent(Guid id, DateTime occurredOn, Guid memberId) : base(id, occurredOn)
        {
            MemberId = memberId;
        }
    }
}
