﻿using Autofac;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.EventBus;
using CompanyName.MyMeetings.Modules.Administration.IntegrationEvents.MeetingGroupProposals;
using CompanyName.MyMeetings.Modules.Meetings.IntegrationEvents;
using CompanyName.MyMeetings.Modules.UserAccess.IntegrationEvents;
using Serilog;

namespace CompanyName.MyMeetings.Modules.Payments.Application.Configuration.EventsBus
{
    public static class EventsBusStartup
    {
        public static void Initialize(
            ILogger logger)
        {
            SubscribeToIntegrationEvents(logger);
        }

        private static void SubscribeToIntegrationEvents(ILogger logger)
        {
            var eventBus = PaymentsCompositionRoot.BeginLifetimeScope().Resolve<IEventsBus>();
            
            SubscribeToIntegrationEvent<MeetingGroupProposalAcceptedIntegrationEvent>(eventBus, logger);
            SubscribeToIntegrationEvent<NewUserRegisteredIntegrationEvent>(eventBus, logger);
            SubscribeToIntegrationEvent<MeetingAttendeeAddedIntegrationEvent>(eventBus, logger);
        }


        private static void SubscribeToIntegrationEvent<T>(IEventsBus eventsBus, ILogger logger)
            where T : IntegrationEvent
        {
            logger.Information("Subscribe to {@IntegrationEvent}", typeof(T).FullName);
            eventsBus.Subscribe(
                new IntegrationEventGenericHandler<T>());
        }
    }
}