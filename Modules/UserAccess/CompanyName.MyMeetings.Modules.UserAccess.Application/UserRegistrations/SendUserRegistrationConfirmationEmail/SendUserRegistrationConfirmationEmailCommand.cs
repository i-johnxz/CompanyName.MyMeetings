using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing.InternalCommands;
using CompanyName.MyMeetings.Modules.UserAccess.Domain.UserRegistrations;
using Newtonsoft.Json;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.UserRegistrations.SendUserRegistrationConfirmationEmail
{
    internal class SendUserRegistrationConfirmationEmailCommand : InternalCommandBase
    {
        [JsonConstructor]
        public SendUserRegistrationConfirmationEmailCommand(Guid id, UserRegistrationId userRegistrationId, string email) : base(id)
        {
            UserRegistrationId = userRegistrationId;
            Email = email;
        }

        internal UserRegistrationId UserRegistrationId { get; }

        internal string Email { get; }
    }
}
