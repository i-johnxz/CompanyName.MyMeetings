using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Serilog;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Logging
{
    public class LoggingModule : Autofac.Module
    {
        private readonly ILogger _logger;

        public LoggingModule(ILogger logger)
        {
            _logger = logger;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(_logger)
                .As<ILogger>()
                .SingleInstance();
        }
    }
}
