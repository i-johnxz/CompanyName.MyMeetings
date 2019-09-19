using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing.Outbox
{
    public class OutboxMessageDto
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public string Data { get; set; }


    }
}
