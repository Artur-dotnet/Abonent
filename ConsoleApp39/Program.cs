using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp39
{
    class Program
    {

       
        static void Main(string[] args)
        {

            CableTVsubscribers cableTVsubscribers = new CableTVsubscribers();
            cableTVsubscribers.AddAbonent(new Abonent()
            {
                Surname = "name",
                Addres = "Addres",
                Phone = "111",
                District = "District",
                NumberContract = 222,
                InstallationCost = 50,
                SubscriptionPayment_month = 150,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(3)
            
            });

            cableTVsubscribers.AddAbonent(new Abonent()
            {
                Surname = "name-2",
                Addres = "Addres-2",
                Phone = "222",
                District = "District-2",
                NumberContract = 333,
                InstallationCost = 60,
                SubscriptionPayment_month = 100,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(4)

            });

            cableTVsubscribers.AddAbonent(new Abonent()
            {
                Surname = "name-3",
                Addres = "Addres-3",
                Phone = "333",
                District = "District-2",
                NumberContract = 333,
                InstallationCost = 40,
                SubscriptionPayment_month = 100,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(5)

            });

            cableTVsubscribers.AddAbonent(new Abonent()
            {
                Surname = "name-4",
                Addres = "Addres-4",
                Phone = "444",
                District = "District-4",
                NumberContract = 444,
                InstallationCost = 50,
                SubscriptionPayment_month = 150,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(6)

            });

            cableTVsubscribers.AddAbonent(new Abonent()
            {
                Surname = "name-5",
                Addres = "Addres-5",
                Phone = "555",
                District = "District-5",
                NumberContract = 333,
                InstallationCost = 50,
                SubscriptionPayment_month = 100,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(2)

            });

            cableTVsubscribers.AddAbonent(new Abonent()
            {
                Surname = "name-6",
                Addres = "Addres-6",
                Phone = "666",
                District = "District-6",
                NumberContract = 333,
                InstallationCost = 40,
                SubscriptionPayment_month = 150,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(4)

            });

            cableTVsubscribers.AddAbonent(new Abonent()
            {
                Surname = "name-6",
                Addres = "Addres-6",
                Phone = "666",
                District = "District-6",
                NumberContract = 333,
                InstallationCost = 40,
                SubscriptionPayment_month = 150,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(4)

            });


            //cableTVsubscribers.Display();
            //cableTVsubscribers.FindByPhone("111");


            cableTVsubscribers.DelAbonent(333);

            cableTVsubscribers.Display();
            Console.WriteLine( cableTVsubscribers.Abonents[0].CalcCostPaymentsAllTime());
                

          

            // 62
            Console.ReadKey();
        }

        
    }
}
