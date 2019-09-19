using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Outbox;
using CompanyName.MyMeetings.Modules.UserAccess.Infrastructure.Outbox;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing.Outbox
{
    internal class OutboxModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<OutboxAccessor>()
                .As<IOutbox>()
                .FindConstructorsWith(new AllConstructorFinder())
                .InstancePerLifetimeScope();
        }
    }
}
