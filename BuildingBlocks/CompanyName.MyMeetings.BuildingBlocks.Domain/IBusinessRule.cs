using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.BuildingBlocks.Domain
{
    public interface IBusinessRule
    {
        bool IsBroken();

        string Message { get; }
    }
}
