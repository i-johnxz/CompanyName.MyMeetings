﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CompanyName.MyMeetings.Modules.Administration.Application.Configuration.Processing.InternalCommands;
using CompanyName.MyMeetings.Modules.Administration.Application.MeetingGroupProposals.RequestMeetingGroupProposalVerification;
using CompanyName.MyMeetings.Modules.Meetings.IntegrationEvents;
using MediatR;

namespace CompanyName.MyMeetings.Modules.Administration.Application.MeetingGroupProposals
{
    public class MeetingGroupProposedIntegrationEventHandler : INotificationHandler<MeetingGroupProposedIntegrationEvent>
    {
        private readonly ICommandsScheduler _commandsScheduler;

        public MeetingGroupProposedIntegrationEventHandler(ICommandsScheduler commandsScheduler)
        {
            _commandsScheduler = commandsScheduler;
        }

        public async Task Handle(MeetingGroupProposedIntegrationEvent notification, CancellationToken cancellationToken)
        {
            await _commandsScheduler.EnqueueAsync(new RequestMeetingGroupProposalVerificationCommand(
                Guid.NewGuid(),
                notification.MeetingGroupProposalId,
                notification.Name,
                notification.Description,
                notification.LocationCity,
                notification.LocationCountryCode,
                notification.ProposalUserId,
                notification.ProposalDate));
        }
    }
}
