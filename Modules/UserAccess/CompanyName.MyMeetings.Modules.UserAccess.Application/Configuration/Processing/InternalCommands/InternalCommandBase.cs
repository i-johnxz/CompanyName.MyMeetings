using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.Modules.UserAccess.Application.Contracts;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing.InternalCommands
{
    internal abstract class InternalCommandBase : ICommand
    {
        public Guid Id { get; }

        protected InternalCommandBase(Guid id)
        {
            Id = id;
        }
    }
}
