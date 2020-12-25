using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Abonent
    {
        public string Surname { get; set; }
        public string District { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }
        public int NumberContract { get; set; }
        public DateTime DateContractCreation { get; set; }

        public decimal InstallationCost { get; set; }
        public decimal SubscriptionPayment_month { get; set; }

        public DateTime DateLastPaymen { get; set; }

        public override string ToString()
        {
            return $"{Surname,15}{NumberContract,15}{SubscriptionPayment_month,15}{InstallationCost,15}{Phone,20}{Addres,30}{District,30}" +
                $"{DateContractCreation.Year,20}.{DateContractCreation.Month}.{DateContractCreation.Day}" +
                $"{DateLastPaymen.Year,20}.{DateLastPaymen.Month}.{DateLastPaymen.Day}";
        }

        public decimal CalcCostPaymentsAllTime()
        {
            decimal sum = 0.0M;
            for (DateTime i = DateContractCreation; i < DateLastPaymen; i = i.AddMonths(1))
            {
                
                sum += SubscriptionPayment_month;
            }

            return sum;
        }
    }
}
