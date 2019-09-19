﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using CompanyName.MyMeetings.Modules.UserAccess.Application.UserRegistrations;
using CompanyName.MyMeetings.Modules.UserAccess.Domain.UserRegistrations;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Domain
{
    internal class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UsersCounter>()
                .As<IUsersCounter>()
                .InstancePerLifetimeScope();
        }
    }
}
