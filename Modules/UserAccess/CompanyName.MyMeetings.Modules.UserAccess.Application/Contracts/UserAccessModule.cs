using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration;
using CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Contracts
{
    public class UserAccessModule : IUserAccessModule
    {
        public async Task<TResult> ExecuteCommandAsync<TResult>(ICommand<TResult> command)
        {
            return await CommandsExecutor.Execute(command);
        }

        public async Task ExecuteCommandAsync(ICommand command)
        {
            await CommandsExecutor.Execute(command);
        }

        public async Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query)
        {
            return await QueryExecutor.Query(query);
        }
    }
}
