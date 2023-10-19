using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mitr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15000; i += 2800)
            {
                User user = new User();
                user.TakeMoney(i);
            }


            Thread.Sleep(2000);
            Console.WriteLine(Bank.GetCount());
            Console.ReadKey();
        }
    }
}
