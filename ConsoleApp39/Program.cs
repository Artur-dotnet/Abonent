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
                District = "District-1",
                NumberContract =111,
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
                District = "District-1",
                NumberContract = 222,
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
                District = "District-3",
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
                District = "District-3",
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
                District = "District-3",
                NumberContract = 555,
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
                NumberContract = 666,
                InstallationCost = 40,
                SubscriptionPayment_month = 150,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(4)

            });

            cableTVsubscribers.AddAbonent(new Abonent()
            {
                Surname = "name-66",
                Addres = "Addres-67",
                Phone = "6667",
                District = "District-6",
                NumberContract = 667,
                InstallationCost = 40,
                SubscriptionPayment_month = 150,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(4)

            });


            

            cableTVsubscribers.DelAbonent(667);

            List<Abonent> abonents = new List<Abonent>();
            abonents.Add(cableTVsubscribers.Abonents[0]);
            abonents.Add(cableTVsubscribers.Abonents[1]);
            abonents.Add(cableTVsubscribers.Abonents[2]);

            Console.WriteLine("======================================================================================= Вывод абонентов ========================================================================================================");
            cableTVsubscribers.Display();
            Console.WriteLine("================================================================================================================================================================================================================");


            Console.WriteLine("======================================================================================= Пересечение абонентов ==================================================================================================");
            cableTVsubscribers.IntersectionOfSubscribers(abonents);
            Console.WriteLine($"  Общая стоимость подписок (с времени заключения контракта до последнего платежа): {cableTVsubscribers.CalcTotalAmountFromSubscriptions()}");
            Console.WriteLine("================================================================================================================================================================================================================");

            List<Abonent> new_abonents = new List<Abonent>();
            new_abonents.Add(new Abonent()
            {
                Surname = "name-8",
                Addres = "Addres-8",
                Phone = "888",
                District = "District-1",
                NumberContract = 888,
                InstallationCost = 50,
                SubscriptionPayment_month = 250,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(4)

            });


            new_abonents.Add(new Abonent()
            {
                Surname = "name-9",
                Addres = "Addres-9",
                Phone = "999",
                District = "District-9",
                NumberContract = 999,
                InstallationCost = 50,
                SubscriptionPayment_month = 350,
                DateContractCreation = DateTime.Now,
                DateLastPaymen = DateTime.Now.AddMonths(2)

            });


            cableTVsubscribers.UnionOfSubscribers(new_abonents);
            Console.WriteLine("======================================================================================= Вывод абонентов ========================================================================================================");
            cableTVsubscribers.Display();
            Console.WriteLine("================================================================================================================================================================================================================");

            CableTVsubscribers ctvs = cableTVsubscribers.GetGroup("District-1");
            Console.WriteLine("======================================================================================= Группа с района ========================================================================================================");
            ctvs.Display();
            Console.WriteLine("================================================================================================================================================================================================================");
            // 62
            Console.ReadKey();
        }

        
    }
}
