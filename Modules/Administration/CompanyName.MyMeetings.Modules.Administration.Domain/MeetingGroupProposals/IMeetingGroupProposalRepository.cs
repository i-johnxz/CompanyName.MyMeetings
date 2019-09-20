using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.MyMeetings.Modules.Administration.Domain.MeetingGroupProposals
{
    public interface IMeetingGroupProposalRepository
    {
        Task AddAsync(MeetingGroupProposal meetingGroupProposal);

        Task<MeetingGroupProposal> GetByIdAsync(MeetingGroupProposalId meetingGroupProposalId);
    }
}
