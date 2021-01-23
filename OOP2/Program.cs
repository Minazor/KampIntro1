using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customerI = new IndividualCustomer();
            customerI.Name = "Mina";
            customerI.Surname = "İnal";
            customerI.Id = 1;
            customerI.TcNo = "2736462714";
            customerI.CustomerNo = "3245";

            CoorporateCompany customerC = new CoorporateCompany();
            customerC.CompanyName = "MinazorSA";
            customerC.Id = 2;
            customerC.CustomerNo = "65423";
            customerC.TaxNo = "353453462";

            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CoorporateCompany();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
