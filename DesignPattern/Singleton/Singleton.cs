using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /*
     * Let us understand why Singleton class Sealed in C# with examples.
     * First, create the Singleton class without using the sealed keyword. We also create another class with the name DerivedSingleton 
     * and then Inherits it from the singleton class as shown below.     * 
     * */
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
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

        // nested class
        public class DerivedSingleton : Singleton
        {
        }
    }    
}
//we cannot derive a sealed class.

