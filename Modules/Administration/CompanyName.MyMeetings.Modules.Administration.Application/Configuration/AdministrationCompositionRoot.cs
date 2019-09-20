﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace CompanyName.MyMeetings.Modules.Administration.Application.Configuration
{
    internal static class AdministrationCompositionRoot
    {
        private static IContainer _container;

        public static void SetContainer(IContainer container)
        {
            _container = container;
        }

        public static ILifetimeScope BeginLifetimeScope()
        {
            return _container.BeginLifetimeScope();
        }
    }
}
