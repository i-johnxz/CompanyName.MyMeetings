using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.Modules.Administration.Application.Configuration.Processing.InternalCommands;
using Newtonsoft.Json;

namespace CompanyName.MyMeetings.Modules.Administration.Application.Members
{
    internal class CreateMemberCommand : InternalCommandBase
    {

        [JsonConstructor]
        public CreateMemberCommand(Guid id, 
            Guid memberId, 
            string login, 
            string email, 
            string firstName, 
            string lastName, 
            string name) : base(id)
        {
            MemberId = memberId;
            Login = login;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Name = name;
        }

        internal Guid MemberId { get; }

        internal string Login { get; }

        internal string Email { get; }

        internal string FirstName { get; }

        internal string LastName { get; }

        internal string Name { get; }
    }
}
