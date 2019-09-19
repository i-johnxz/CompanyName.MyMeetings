using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Contracts
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
        Guid Id { get; }
    }
}
