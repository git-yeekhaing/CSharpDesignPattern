using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }    
}
/*
 * The above code implementation using lock solves 
 * the multithreading issue. But the problem is that 
 * it is slow down your application as only one thread 
 * can access the GetInstance property at any given point of time.
 * We can overcome the above problem by using the Double-checked 
 * locking mechanism.
*/