﻿using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.UserAccess.Domain.UserRegistrations.Events
{
    public class NewUserRegisteredDomainEvent : DomainEventBase
    {
        public UserRegistrationId UserRegistrationId { get; }

        public string Login { get; }

        public string Email { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Name { get; }

        public DateTime RegisterDate { get; }

        public NewUserRegisteredDomainEvent(
            UserRegistrationId userRegistrationId, 
            string login, 
            string email, 
            string firstName, 
            string lastName, 
            string name, 
            DateTime registerDate)
        {
            UserRegistrationId = userRegistrationId;
            Login = login;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Name = name;
            RegisterDate = registerDate;
        }
    }
}
