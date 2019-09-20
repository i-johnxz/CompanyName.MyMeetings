﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CompanyName.MyMeetings.Modules.Administration.Application.Configuration.Processing;
using CompanyName.MyMeetings.Modules.Administration.Domain.Members;
using MediatR;

namespace CompanyName.MyMeetings.Modules.Administration.Application.Members
{
    internal class CreateMemberCommandHandler : ICommandHandler<CreateMemberCommand>
    {
        private readonly IMemberRepository _memberRepository;

        public CreateMemberCommandHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<Unit> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            var member = Member.Create(request.MemberId,
                request.Login,
                request.Email,
                request.FirstName,
                request.LastName,
                request.Name);

            await _memberRepository.AddAsync(member);

            return Unit.Value;
        }
    }
}
