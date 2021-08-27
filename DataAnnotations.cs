using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First
{
    class DataAnnotations
    {

        static void Main(string[] args)
        {
            try
            {
                MyDbContext db = new MyDbContext();

                Broker obj = new Broker();
                obj.BrokerId = 1;
                obj.BrokerCode = "STANC";
                obj.BrokerName = "Standard Chartered Bank Ltd";
                db.Brokers.Add(obj);
                db.SaveChanges();

                Console.WriteLine("Code First Table Created");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
