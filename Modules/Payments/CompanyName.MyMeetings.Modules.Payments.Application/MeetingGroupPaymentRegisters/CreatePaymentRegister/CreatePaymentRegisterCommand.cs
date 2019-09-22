using System;
using CompanyName.MyMeetings.Modules.Payments.Application.Configuration.Processing.InternalCommands;
using Newtonsoft.Json;

namespace CompanyName.MyMeetings.Modules.Payments.Application.MeetingGroupPaymentRegisters.CreatePaymentRegister
{
    internal class CreatePaymentRegisterCommand : InternalCommandBase
    {
        [JsonConstructor]
        public CreatePaymentRegisterCommand(Guid id, Guid meetingGroupProposalId) : base(id)
        {
            MeetingGroupProposalId = meetingGroupProposalId;
        }
        
        
        internal Guid MeetingGroupProposalId { get; }
    }
}