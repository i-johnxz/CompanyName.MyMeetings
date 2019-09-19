using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Quartz;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Quartz
{
    public class QuartzModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(x => typeof(IJob).IsAssignableFrom(x)).InstancePerDependency();
        }
    }
}
