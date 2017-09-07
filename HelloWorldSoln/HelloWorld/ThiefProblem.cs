using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ThiefProblem
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(args[0]);
            int i;
            if (length != 0)
            {
                //int[] arr = new int[length];
                int money=0;
                for (i = 1; i < args.Length; i+=2)
                {
                    if (Convert.ToInt32(args[i]) % 2 == 0)
                    {
                        money = Convert.ToInt32(args[i]) / 2 * Convert.ToInt32(args[i + 1]);
                    }
                    else
                    {
                        money = (Convert.ToInt32(args[i]) / 2 + 1) * Convert.ToInt32(args[i + 1]);
                    }
                    Console.WriteLine("money = " + money);
                }
                
            }
            Console.Read();

        }
    }
}
