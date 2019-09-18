﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CompanyName.MyMeetings.BuildingBlocks.Infrastructure
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
}
