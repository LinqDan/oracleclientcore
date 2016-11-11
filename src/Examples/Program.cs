using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;

using System.Data.OracleClient;

namespace Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start.");

            Console.WriteLine("create OracleConnection object...");
            using (var connection = new OracleConnection("Data Source=ORADB12;User ID=SYSTEM;Password=BLISS21"))
            {
                Console.WriteLine("Open connection...");
                connection.Open();

                Console.WriteLine("Create command...");
                using (var command = connection.CreateCommand())
                {

                    command.CommandText = "SELECT TABLE_NAME FROM ALL_TABLES ORDER BY 1";

                    Console.WriteLine("Execute reader...");
                    using (var reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Tables:");

                        while (reader.Read())
                        {
                            string tableName = reader.GetString(reader.GetOrdinal("TABLE_NAME"));
                            Console.WriteLine(tableName);
                        };
                    }
                }
            }
            Console.WriteLine("Done.");
        }

    }
}
