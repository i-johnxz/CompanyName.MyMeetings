using CompanyName.MyMeetings.Modules.UserAccess.Application.Contracts;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Authentication.Authenticate
{
    public class AuthenticateCommand : CommandBase<AuthenticationResult>
    {
        public AuthenticateCommand(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
