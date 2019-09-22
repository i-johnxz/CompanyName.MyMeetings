﻿using Autofac;
using CompanyName.MyMeetings.BuildingBlocks.Application;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Emails;
using CompanyName.MyMeetings.Modules.Meetings.Application.Configuration.Authentication;
using CompanyName.MyMeetings.Modules.Meetings.Application.Configuration.DataAccess;
using CompanyName.MyMeetings.Modules.Meetings.Application.Configuration.Email;
using CompanyName.MyMeetings.Modules.Meetings.Application.Configuration.EventsBus;
using CompanyName.MyMeetings.Modules.Meetings.Application.Configuration.Logging;
using CompanyName.MyMeetings.Modules.Meetings.Application.Configuration.Mediation;
using CompanyName.MyMeetings.Modules.Meetings.Application.Configuration.Processing;
using CompanyName.MyMeetings.Modules.Meetings.Application.Configuration.Processing.Outbox;
using CompanyName.MyMeetings.Modules.Meetings.Application.Configuration.Quartz;
using Serilog;
using Serilog.AspNetCore;

namespace CompanyName.MyMeetings.Modules.Meetings.Application.Configuration
{
    public class MeetingsStartup
    {
        private static IContainer _container;

        public static void Initialize(
            string connectionString, 
            IExecutionContextAccessor executionContextAccessor,
            ILogger logger,
            EmailsConfiguration emailsConfiguration)
        {
            var moduleLogger = logger.ForContext("Module", "Meetings");

            ConfigureCompositionRoot(connectionString, executionContextAccessor, moduleLogger, emailsConfiguration);

            QuartzStartup.Initialize(moduleLogger);

            EventsBusStartup.Initialize(moduleLogger);
        }

        private static void ConfigureCompositionRoot(
            string connectionString, 
            IExecutionContextAccessor executionContextAccessor, 
            ILogger logger,
            EmailsConfiguration emailsConfiguration)
        {
            var containerBuilder = new ContainerBuilder();
          
            containerBuilder.RegisterModule(new LoggingModule(logger.ForContext("Module", "Meetings")));
            
            var loggerFactory = new SerilogLoggerFactory(logger);
            containerBuilder.RegisterModule(new DataAccessModule(connectionString, loggerFactory));

            containerBuilder.RegisterModule(new ProcessingModule());
            containerBuilder.RegisterModule(new EventsBusModule());
            containerBuilder.RegisterModule(new MediatorModule());
            containerBuilder.RegisterModule(new AuthenticationModule());
            containerBuilder.RegisterModule(new OutboxModule());
            containerBuilder.RegisterModule(new EmailModule(emailsConfiguration)); 
            containerBuilder.RegisterModule(new QuartzModule()); 

            containerBuilder.RegisterInstance(executionContextAccessor);

            _container = containerBuilder.Build();

            MeetingsCompositionRoot.SetContainer(_container);
        }
    } 
}