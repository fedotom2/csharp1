using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace lab1_1
{
    class Program
    {
        static string data = System.IO.File.ReadAllText(@"../../data.json");
        static Dictionary<int, string> dictionary = JsonConvert.DeserializeObject<Dictionary<int, string>>(data);

        static string translate(int x)
        {
            return dictionary[x];
        }

        static void bitCapacity(int x, int divider = 1000000)
        {
            if (x / divider != 0)
            {
                if (divider != 1)
                {
                    Console.Write(translate(x / divider % 10 * divider) + " ");
                    bitCapacity(x, divider / 10);
                } else
                {
                    Console.Write(translate(x % 10));
                }
            } else
            {
                bitCapacity(x, divider / 10);
            }
        }

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            // bitCapacity(x);
            // Console.WriteLine(x % 100);
            Console.WriteLine("High order: ");
            Console.WriteLine(x / 1000);
            Console.WriteLine((x / 1000) / 100 % 10);
            Console.WriteLine((x / 1000) / 10 % 10);
            Console.WriteLine((x / 1000) % 10);
            Console.WriteLine("Low order: ");
            Console.WriteLine(x % 1000);
            Console.WriteLine((x % 1000) / 100 % 10);
            Console.WriteLine((x % 1000) / 10 % 10);
            Console.WriteLine((x % 1000) % 10);

            Console.ReadLine();
        }
    }
}
