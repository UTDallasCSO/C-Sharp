using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class consonant
    {
        static void cns(string[] args)
        {
            string[] names = { "Dave", "Jane", "Jack", "Matthew" };
            foreach(string n in names)
            {
                Console.WriteLine("Name is: {0}", n);
            }

            int[] val = { 1, 2, 3, 4 };

            /* Initialization of array*/
            int[] values = new int[100];
            for(int i=0;i<100;i++)
            {
                values[i] = i+1;
            }

            /*Display array*/
            for(int i=0;i<100;i++)
            {
                Console.WriteLine(values[i]);
            }
          
            Console.ReadKey();
        }
    }
}
