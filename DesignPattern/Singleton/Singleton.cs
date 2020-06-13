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
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        // creates the Singleton instance at the time of application startup.
        private static readonly Singleton instance = new Singleton();
        public static Singleton GetInstance
        {
            get
            {
                return instance;
            }
        }        

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
/*
You can see that only one instance got created as 
the Counter value is 1. The above Singleton class is thread-safe
after removing the lock variables. 
This is because the now the CLR (Common Language Runtime) will internally 
take care of the variable initialization as well as thread safety in eager loading.
*/
