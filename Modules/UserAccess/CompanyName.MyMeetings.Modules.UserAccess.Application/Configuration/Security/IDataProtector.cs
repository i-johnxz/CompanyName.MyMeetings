using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Security
{
    public interface IDataProtector
    {
        string Encrypt(string plainText);

        string Decrypt(string encryptedText);
    }
}
