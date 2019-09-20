using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.Modules.Administration.Application.Configuration.Processing.InternalCommands;
using Newtonsoft.Json;

namespace CompanyName.MyMeetings.Modules.Administration.Application.MeetingGroupProposals.RequestMeetingGroupProposalVerification
{
    internal class RequestMeetingGroupProposalVerificationCommand : InternalCommandBase
    {
        public Guid MeetingGroupProposalId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string LocationCity { get; set; }

        public string LocationCountryCode { get; set; }

        public Guid ProposalUserId { get; set; }

        public DateTime ProposalDate { get; set; }

        [JsonConstructor]
        public RequestMeetingGroupProposalVerificationCommand(
            Guid id, 
            Guid meetingGroupProposalId, 
            string name, 
            string description, 
            string locationCity, 
            string locationCountryCode, 
            Guid proposalUserId, 
            DateTime proposalDate) : base(id)
        {
            MeetingGroupProposalId = meetingGroupProposalId;
            Name = name;
            Description = description;
            LocationCity = locationCity;
            LocationCountryCode = locationCountryCode;
            ProposalUserId = proposalUserId;
            ProposalDate = proposalDate;
        }
    }
}
