﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Emails;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Email
{
    internal class EmailModule : Module
    {
        private readonly EmailsConfiguration _configuration;

        public EmailModule(EmailsConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmailSender>()
                .As<IEmailSender>()
                .WithParameter("configuration", _configuration)
                .InstancePerLifetimeScope();
        }
    }
}
