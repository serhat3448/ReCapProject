using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            UserAddTest();
            CustomerAddTest();
            

        }


        private static void UserAddTest()
        {

            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User
            {
                FirstName = "Serhat",
                LastName = "Doğru",
                Email = "serhatdogru@test.com",
                Password = "123456"

            });
            Console.WriteLine(result.Message);

        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                UserId = 3,
                CompanyName = "Akyürek Bolatlı Ltd. Şti."

                
            });
        }

    }
}
