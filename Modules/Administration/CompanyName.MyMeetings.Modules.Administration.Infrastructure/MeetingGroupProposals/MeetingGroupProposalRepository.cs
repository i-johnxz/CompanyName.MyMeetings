﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompanyName.MyMeetings.Modules.Administration.Domain.MeetingGroupProposals;
using Microsoft.EntityFrameworkCore;

namespace CompanyName.MyMeetings.Modules.Administration.Infrastructure.MeetingGroupProposals
{
    internal class MeetingGroupProposalRepository : IMeetingGroupProposalRepository
    {

        private readonly AdministrationContext _context;

        public MeetingGroupProposalRepository(AdministrationContext context)
        {
            _context = context;
        }

        public async Task AddAsync(MeetingGroupProposal meetingGroupProposal)
        {
            await _context.MeetingGroupProposals.AddAsync(meetingGroupProposal);
        }

        public async Task<MeetingGroupProposal> GetByIdAsync(MeetingGroupProposalId meetingGroupProposalId)
        {
            return await _context.MeetingGroupProposals.FirstOrDefaultAsync(x => x.Id == meetingGroupProposalId);
        }
    }
}
