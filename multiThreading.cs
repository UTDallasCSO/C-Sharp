using System;
using System.Threading;

/*public class Cuboid
{
    private int height;
    private int width;
    private int length;
    
    public Cuboid()
    {
        Console.WriteLine("This is instantiating the class.");
    }
      public void setHeight(int h)
    {
        height = h;
    }
    public int getHeight()
    {
        return height;
    }
    public int getWidth()
    {
        return width;
    }
    public void setWidth(int w)
    {
        width = w;
    }
    public int getLength()
    {
        return length;
    }
    public void setLength(int l)
    {
        length = l;
    }
    public int calcVolume()
    {
        return (height * width * length);
    }
}
public class Calculate: Cuboid
{
    public static void min(string[] args)
    {
        Cuboid c = new Cuboid();
        c.setHeight(5);
        c.setLength(4);
        c.setWidth(10);
        Console.WriteLine("Volume is: {0}", c.calcVolume());
        Console.ReadKey();
    }
}*/

namespace MultithreadingApplication
{
    class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");

            // the thread is paused for 5000 milliseconds
            int sleepfor = 5000;

            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        static void aain(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}