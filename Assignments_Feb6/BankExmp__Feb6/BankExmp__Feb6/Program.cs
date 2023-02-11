using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExmp__Feb6
{
    public class Bank
    {
        protected void PersonalDetails()
        {
            Console.WriteLine("PersonalDetails of the Customer");
        }
        private void SalaryDetails()
        {
            Console.WriteLine("SalaryDetails");
        }
    }
    class ThirdParty:Bank           //This Card details is inherited from the parent class Bank
    {
        static void Main(string[] args)
        {
            ThirdParty card = new ThirdParty();
            card.PersonalDetails();
        }
    }
}

