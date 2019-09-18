using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Authentication
{
    public class PasswordManager
    {
        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }

            byte[] dst = new byte[0x31];
            return String.Empty;
        }
    }
}
