using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Contracts
{
    public abstract class QueryBase
    {
        public Guid Id { get; set; }

        protected QueryBase()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
