using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using CostingPlatform;

namespace CostingPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            UserIdentity firstUser = new UserIdentity();

            firstUser.FirstNmae = "Dimma";
            firstUser.LastName = "Onuoha";
            firstUser.UserName = "Dee";
            firstUser.EmailAddress = "errthingred@gmal.com";
            firstUser.PhoneNumber = "+2348124897815";
            firstUser.CompanyInfo.Name = "SweetCrustng";
            firstUser.CompanyInfo.PhoneNumber = "+2348124897815";
            firstUser.CompanyInfo.Location = "Lagos";

            WriteLine($"The company associated to {firstUser.UserName} is {firstUser.CompanyInfo.Name} and it is located in {firstUser.CompanyInfo.Location}");

            ReadLine();
        }




    }
}
