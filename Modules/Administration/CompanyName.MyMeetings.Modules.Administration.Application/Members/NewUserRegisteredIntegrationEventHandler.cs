﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CompanyName.MyMeetings.Modules.Administration.Application.Configuration.Processing.InternalCommands;
using CompanyName.MyMeetings.Modules.UserAccess.IntegrationEvents;
using MediatR;

namespace CompanyName.MyMeetings.Modules.Administration.Application.Members
{
    internal class NewUserRegisteredIntegrationEventHandler : INotificationHandler<NewUserRegisteredIntegrationEvent>
    {
        private readonly ICommandsScheduler _commandsScheduler;

        public NewUserRegisteredIntegrationEventHandler(ICommandsScheduler commandsScheduler)
        {
            _commandsScheduler = commandsScheduler;
        }


        public Task Handle(NewUserRegisteredIntegrationEvent notification, CancellationToken cancellationToken)
        {
            _commandsScheduler.EnqueueAsync(new CreateMemberCommand(
                Guid.NewGuid(),
                notification.UserId,
                notification.Login,
                notification.Email,
                notification.FirstName,
                notification.LastName,
                notification.Name
            ));

            return Task.CompletedTask;
        }
    }
}
