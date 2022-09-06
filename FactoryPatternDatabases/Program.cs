using System;
using System.Collections.Generic;
using System.Threading;

namespace FactoryPatternDatabases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("Which database would you like to use... List, SQL, or Mongo?");
                userInput = Console.ReadLine();

                if (userInput != "sql" && userInput != "list" && userInput != "mongo")
                {
                    correctInput = false;
                    Console.WriteLine("Bad input");
                    Thread.Sleep(1000);
                }
            } while (!correctInput);
                Console.Clear ();
                IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            }
            
        }
    }
}
