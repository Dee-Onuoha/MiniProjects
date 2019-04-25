using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CostingPlatform
{
    public class UserIdentity
    {
        public string UserName { get; set; }

        public string FirstNmae { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public UserCompanyInfo CompanyInfo { get; internal set; }


        public UserIdentity()
        {
            CompanyInfo = new UserCompanyInfo();
        }

        public UserIdentity(string userName,
            string firstName,
            string lastName,
            string emailAddress) : this(userName, firstName, lastName)
        {
            EmailAddress = emailAddress;
        }

        public UserIdentity(string userName, string firstName, string lastName) : this()
        {
            FirstNmae = firstName;
            LastName = lastName;
            UserName = userName ?? Guid.NewGuid().ToString();
        }

        public string FullName2
        {
            get
            {
                return $"{FirstNmae} {LastName}";
            }
        }

        public string FullName => $"{FirstNmae ?? ""} {LastName ?? ""}";
    }

    public class UserCompanyInfo
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string PhoneNumber { get; set; }
    }

    
}
