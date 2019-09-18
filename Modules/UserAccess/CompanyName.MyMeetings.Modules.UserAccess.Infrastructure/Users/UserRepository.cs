﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompanyName.MyMeetings.Modules.UserAccess.Domain.Users;

namespace CompanyName.MyMeetings.Modules.UserAccess.Infrastructure.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly UserAccessContext _userAccessContext;

        public UserRepository(UserAccessContext userAccessContext)
        {
            _userAccessContext = userAccessContext;
        }

        public async Task AddAsync(User user)
        {
            await _userAccessContext.Users.AddAsync(user);
        }
    }
}
