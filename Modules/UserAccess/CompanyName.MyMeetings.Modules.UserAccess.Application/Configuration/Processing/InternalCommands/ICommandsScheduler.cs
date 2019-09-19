using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompanyName.MyMeetings.Modules.UserAccess.Application.Contracts;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing.InternalCommands
{
    public interface ICommandsScheduler
    {
        Task EnqueueAsync(ICommand command);
    }
}
