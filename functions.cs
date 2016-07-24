using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class functions
    {
        static void func(string[] args)
        {
            int sum=add(1, 2);
            Console.WriteLine(sum);
            bool value = check(1,2);
            Console.WriteLine(value);
            Console.ReadKey();
        }
        public static int add(int a,int b)
        {
            int sum = a + b;
            return sum;
        }
        public static bool check(int a,int b)
        {
            if(a>b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
