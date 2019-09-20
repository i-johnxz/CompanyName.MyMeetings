using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing.InternalCommands;
using CompanyName.MyMeetings.Modules.UserAccess.Domain.UserRegistrations;
using Newtonsoft.Json;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Users.CreateUser
{
    internal class CreateUserCommand :InternalCommandBase
    {
        public CreateUserCommand(Guid id, UserRegistrationId userRegistrationId) : base(id)
        {
            UserRegistrationId = userRegistrationId;
        }

        public UserRegistrationId UserRegistrationId;
    }
}
