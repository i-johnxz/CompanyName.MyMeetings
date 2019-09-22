using System;
using Microsoft.AspNetCore.Authorization;

namespace CompanyName.MyMeetings.API.Configuration.Authorization
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class HasPermissionAttribute : AuthorizeAttribute
    {
        internal static string HasPermissionPolicyName = "HasPermission";

        public string Name { get; set; }

        public HasPermissionAttribute(string name)
            :base(HasPermissionPolicyName)
        {
            Name = name;
        }
    }
}