using Microsoft.Data.SqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {

        static  void Main()
        {
           Database database = new Database();
           if(database.TryConect())
            {
                //   List<Objects.Oll> list = new List<Objects.Oll>();
                Console.WriteLine("Get oll buyers");
                var olllist =  database.GetOll();
                Console.WriteLine("\nGet oll emails");
                var emaillist =  database.Getemails();
                Console.WriteLine("\nGet oll sections");
                var sectionlist =  database.Getsection();
                Console.WriteLine("\nGet oll goods");
                var goodlist =  database.Getgoods();
                Console.WriteLine("\nGet oll countrys");
                var countrylist =  database.Getcountrys();
                Console.WriteLine("\nGet oll citys");
                var citylist =  database.Getcitys();
                Console.WriteLine("\nGet oll from counrty");
                var getbycitylist =  database.Get_by_city("Лондон");
                Console.WriteLine("\nGet oll from city");
                var getbycounty =  database.Get_by_country("Україна");
                Console.WriteLine("\nGet oll goods from country");
                var getgoodbycounty =  database.Get_good_by_country("Україна");









            }
          





        }
    }
}
