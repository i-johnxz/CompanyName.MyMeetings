﻿using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.SeedWork;
using CompanyName.MyMeetings.Modules.Administration.Domain.MeetingGroupProposals.Events;
using Newtonsoft.Json;

namespace CompanyName.MyMeetings.Modules.Administration.Application.MeetingGroupProposals.AcceptMeetingGroupProposal
{
    public class MeetingGroupProposalAcceptedNotification : DomainNotificationBase<MeetingGroupProposalAcceptedDomainEvent>
    {
        [JsonConstructor]
        public MeetingGroupProposalAcceptedNotification(MeetingGroupProposalAcceptedDomainEvent domainEvent) : base(domainEvent)
        {
        }
    }
}
