using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class CableTVsubscribers
    {

        public List<Abonent> Abonents { get; set; } = new List<Abonent>();

        



        public void Display()
        {
            foreach (Abonent a in Abonents)
            {
                Console.WriteLine($"{a}");
            }
        }

        public void AddAbonent(Abonent a)
        {
            Abonents.Add(a);
            Console.WriteLine("  Абонент успешно добавлен");
        }

        public void DelAbonent(int numberContract)
        {

            bool flag = false;
            foreach(Abonent a in Abonents)
            {
                if(a.NumberContract == numberContract)
                {
                    Abonents.Remove(a);
                    flag = true;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("  Абонент успешно удален");
            else
                Console.WriteLine("  Абонент не найден");
        }


        public void FindByContractNumber(int numberContract)
        {
            bool flag = false;
            foreach (Abonent a in Abonents)
            {
                if (a.NumberContract == numberContract)
                {
                    Console.WriteLine($"{a}");
                    flag = true;
                    break;
                }
            }

            if (!flag)
                Console.WriteLine("  Абонент не найден");
        }

        public void FindByPhone(string phone)
        {
            var v = Abonents.Where<Abonent>(a => a.Phone == phone);
            foreach(var a in v)
            {
                Console.WriteLine($"{a}");
            }
        }

        public void FindBySurname(string surname)
        {
            var v = Abonents.Where(a => a.Surname == surname);
            foreach (var a in v)
            {
                Console.WriteLine($"{a}");
            }
        }


        public void FindByDateContractCreation(int year, int mounth, int day)
        {
            var v = Abonents.Where(a => (a.DateContractCreation.Day == day && a.DateContractCreation.Month == mounth && a.DateContractCreation.Year == year));
            foreach (var a in v)
            {
                Console.WriteLine($"{a}");
            }

        }


        public decimal CalcTotalAmountFromSubscriptions()
        {
            decimal sum = 0.0M;

            foreach(Abonent a in Abonents)
            {
                sum += a.CalcCostPaymentsAllTime();
            }

            return sum;
        }

        public CableTVsubscribers GetGroup(string district)
        {
            CableTVsubscribers group = new CableTVsubscribers();
            foreach (Abonent a in Abonents)
            {
                if(a.District == district)
                {
                    group.AddAbonent(a);
                }

            }
            return group;
        }



        public void UnionOfSubscribers(List<Abonent> u)
        {
            Abonents.AddRange(u); // Abonents.Union(u);
            Console.WriteLine(" Список абонентов добавлен в основной список");
        }

        public void IntersectionOfSubscribers(List<Abonent> a)
        {
            var v = Abonents.Intersect(a);
            Console.WriteLine(" Пересечение абонентов:");
            foreach(var abonent in v)
            {
                Console.WriteLine($" {abonent}");
            }
        }
    }
}
