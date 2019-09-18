using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Emails
{
    public interface IEmailSender
    {
        void SendEmail(EmailMessage message);
    }
}
