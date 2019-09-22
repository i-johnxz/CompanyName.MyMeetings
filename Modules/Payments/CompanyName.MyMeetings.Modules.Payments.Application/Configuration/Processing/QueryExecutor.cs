using System.Threading.Tasks;
using Autofac;
using CompanyName.MyMeetings.Modules.Payments.Application.Contracts;
using MediatR;

namespace CompanyName.MyMeetings.Modules.Payments.Application.Configuration.Processing
{
    internal static class QueryExecutor
    {
        internal static async Task<TResult> Execute<TResult>(IQuery<TResult> query)
        {
            using (var scope = PaymentsCompositionRoot.BeginLifetimeScope())
            {
                var mediator = scope.Resolve<IMediator>();
                return await mediator.Send(query);
            }
        }
    }
}