﻿using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.Modules.UserAccess.Application.Contracts;
using MediatR;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing
{
    public interface IQueryHandler<in TQuery, TResult> :
        IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
    }
}
