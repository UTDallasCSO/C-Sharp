using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    static class ExtensionMethods
    {
        public static int MultiplyByThree(this int value)
        {
            return value * 3;
        }
    }
    class Class1
    {
        static void an()
        {
            int[] array = { 1, 3, 5, 7 };
            Console.WriteLine(array.Average());

            Console.WriteLine(3.MultiplyByThree());

            //string[] array1 = {"Varshini","Sarthak","Matthew" };
            int[] array1 = { 1, 3, 5, 7 };
            int[] array2 = { 2, 3, 5, 7 };
            //string[] array2 = { "Varshini", "Andrew", "Matthew" };
            var inter = array1.Intersect(array2);
            foreach(int value in inter)
            {
                Console.WriteLine(value);
            }

            int[] values = { 1, 3, 4, 5, 7 };
            int single = values.Single(element => element > 4);
            Console.WriteLine(single);
            Console.ReadKey();
        }
        
    }
}
