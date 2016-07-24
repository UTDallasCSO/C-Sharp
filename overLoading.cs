using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Class2
    {
        public void see(int v)
        {
            Console.WriteLine("Int value: {0}", v);
        }
        public void see(float v)
        {
            Console.WriteLine("Float value: {0}", v);
        }
        public void see(string v)
        {
            Console.WriteLine("String value: {0}", v);
        }
        public static void ain(string[] args)
        {
            Class2 c = new Class2();
            c.see(4);
            c.see(4.5f);
            c.see("User");
            Console.ReadKey();
        }
        
    }
}
