using Microsoft.Data.SqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Database
    {

        string connectionString;
        public SqlConnection connection;

        public Database()
        {
            connectionString = @"Data Source=LAPTOP-2CTM7RH1\SHTEPSILL;Initial Catalog=Mailinglist;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(connectionString);
        }



        public Database(string con)
        {
            connectionString = con;
            connection = new SqlConnection(con);

        }

        public bool TryConect()
        {
            try
            {
                using (connection)
                {
                    Console.WriteLine("connect");
                    return true;
                }
            }
            catch
            {
                Console.WriteLine("can`t connect");
                return false;
            }

        }
      

        public async Task<List<Objects.Oll>> GetOll()
        {
                    SqlConnection connection = new SqlConnection(connectionString);

        connection.Open();

            List<Objects.Oll> list= connection.Query<Objects.Oll>("select * from buyers").ToList<Objects.Oll>();
            connection.Close();
            foreach (Objects.Oll oll in list)
            {
                Console.WriteLine(oll);
            }

            return list;

        }

        public async Task<List<string>> Getemails()
        {
            connection = new SqlConnection(connectionString);

            connection.Open();

            List<string> list = connection.Query<string>("select email from buyers").ToList<string>();
            connection.Close();
            foreach (string email in list)
            {
                Console.WriteLine($"{email}");
            }

            return list;

        }
        public async Task<List<string>> Getsection()
        {
            connection = new SqlConnection(connectionString);

            connection.Open();

            List<string> list = connection.Query<string>("select section from section").ToList<string>();
            connection.Close();
            foreach (string section in list)
            {
                Console.WriteLine($"{section}");
            }

            return list;

        }

        public async Task<List<string>> Getgoods()
        {
            connection = new SqlConnection(connectionString);

            connection.Open();

            List<string> list = connection.Query<string>("select good from action").ToList<string>();
            connection.Close();
            foreach (string good in list)
            {
                Console.WriteLine($"{good}");
            }

            return list;

        }


        public async Task<List<string>> Getcountrys()
        {
            connection = new SqlConnection(connectionString);

            connection.Open();

            List<string> list = connection.Query<string>("select country from buyers").ToList<string>();
            connection.Close();
            foreach (string country in list)
            {
                Console.WriteLine($"{country}");
            }

            return list;

        }
        public async Task<List<string>> Getcitys()
        {
            connection = new SqlConnection(connectionString);

            connection.Open();

            List<string> list = connection.Query<string>("select city from buyers").ToList<string>();
            connection.Close();
            foreach (string city in list)
            {
                Console.WriteLine($"{city}");
            }

            return list;

        }

        public async Task<List<Objects.Oll>> Get_by_city(string city)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            List<Objects.Oll> list = connection.Query<Objects.Oll>("get_by_city @city", new { @city = city }).ToList<Objects.Oll>();
            connection.Close();
            foreach (Objects.Oll oll in list)
            {
                Console.WriteLine(oll);
            }

            return list;

        }
        public async Task<List<Objects.Oll>> Get_by_country(string country)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            List<Objects.Oll> list = connection.Query<Objects.Oll>("get_by_county @country", new { @country = country }).ToList<Objects.Oll>();
            connection.Close();
            foreach (Objects.Oll oll in list)
            {
                Console.WriteLine(oll);
            }

             return list;

        }
        public async Task<List<Objects.Action>> Get_good_by_country(string country)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            List<Objects.Action> list = connection.Query<Objects.Action>("get_good_by_country @country", new { @country = country }).ToList<Objects.Action>();
            connection.Close();
            foreach (Objects.Action act in list)
            {
                Console.WriteLine(act);
            }

            return list;

        }


        public async Task<List<Objects.Action>> Get_count_by_country(string country)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            List<Objects.Action> list = connection.Query<Objects.Action>("get_good_by_country @country", new { @country = country }).ToList<Objects.Action>();
            connection.Close();
            foreach (Objects.Action act in list)
            {
                Console.WriteLine(act);
            }

            return list;

        }











    }
}
