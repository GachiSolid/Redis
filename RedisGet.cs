using StackExchange.Redis;
using System;

namespace RedisGet
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ConfigurationOptions();
            options.EndPoints.Add("localhost", 6379);

            var redis = ConnectionMultiplexer.Connect(options);
            var db = redis.GetDatabase();

            string command = "";
            while (command != "0")
            {
                Console.Write("1.Key: ");
                string key1 = Console.ReadLine();

                Console.Write("2.Key: ");
                string key2 = Console.ReadLine();

                Console.WriteLine($"Result: {(int)db.StringGet(key1) * (int)db.StringGet(key2)}");

                Console.WriteLine("Для выхода нажмите 0");
                command = Console.ReadLine();
            }
        }
    }
}
