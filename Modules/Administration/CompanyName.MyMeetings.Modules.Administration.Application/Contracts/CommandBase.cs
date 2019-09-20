using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.Modules.Administration.Application.Contracts
{
    public class CommandBase : ICommand
    {
        public Guid Id { get; }

        public CommandBase()
        {
            this.Id = Guid.NewGuid();
        }

        public CommandBase(Guid id)
        {
            this.Id = id;
        }
    }
}
