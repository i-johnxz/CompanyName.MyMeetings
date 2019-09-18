using CompanyName.MyMeetings.BuildingBlocks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.Modules.UserAccess.Domain.Users
{
    public class UserId : TypedIdValueBase
    {
        public UserId(Guid value) : base(value)
        {
        }
    }
}
