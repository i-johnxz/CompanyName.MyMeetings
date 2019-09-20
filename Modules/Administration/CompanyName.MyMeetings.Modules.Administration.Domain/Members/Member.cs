using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Domain;
using CompanyName.MyMeetings.Modules.Administration.Domain.Members.Events;

namespace CompanyName.MyMeetings.Modules.Administration.Domain.Members
{
    public class Member : Entity, IAggregateRoot
    {

        public MemberId Id { get; set; }

        private string _login;

        private string _email;

        private string _firstName;

        private string _lastName;

        private string _name;

        private DateTime _createDate;

        private Member()
        {
            // Only for EF.
        }

        public static Member Create(Guid id, string login, string email, string firstName, string lastName, string name)
        {
            return new Member(id, login, email, firstName, lastName, name);
        }


        public Member(Guid id, string login, string email, string firstName, string lastName, string name)
        {
            Id = new MemberId(id);
            _login = login;
            _email = email;
            _firstName = firstName;
            _lastName = lastName;
            _name = name;
            _createDate = DateTime.UtcNow;

            this.AddDomainEvent(new MemberCreatedDomainEvent(this.Id));
        }
    }
}
