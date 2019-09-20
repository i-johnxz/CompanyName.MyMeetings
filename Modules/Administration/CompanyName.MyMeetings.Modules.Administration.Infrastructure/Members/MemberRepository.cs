using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompanyName.MyMeetings.Modules.Administration.Domain.Members;
using Microsoft.EntityFrameworkCore;

namespace CompanyName.MyMeetings.Modules.Administration.Infrastructure.Members
{
    internal class MemberRepository : IMemberRepository
    {
        private readonly AdministrationContext _administrationContext;

        public MemberRepository(AdministrationContext administrationContext)
        {
            _administrationContext = administrationContext;
        }


        public async Task AddAsync(Member member)
        {
            await _administrationContext.Members.AddAsync(member);
        }

        public async Task<Member> GetByIdAsync(MemberId memberId)
        {
            return await _administrationContext.Members.FirstOrDefaultAsync(x => x.Id == memberId);
        }
    }
}
