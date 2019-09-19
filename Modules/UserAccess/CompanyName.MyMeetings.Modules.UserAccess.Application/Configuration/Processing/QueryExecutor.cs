using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using CompanyName.MyMeetings.Modules.UserAccess.Application.Contracts;
using MediatR;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing
{
    internal static class QueryExecutor
    {
        internal static async Task<TResult> Query<TResult>(IQuery<TResult> query)
        {
            using (var scope = UserAccessCompositionRoot.BeginLifetimeScope())
            {
                var mediator = scope.Resolve<IMediator>();
                return await mediator.Send(query);
            }
        }
    }
}
