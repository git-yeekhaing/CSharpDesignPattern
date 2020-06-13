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
    public class Singleton
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
    }

    //‘Singleton.Singleton()’ is inaccessible due to its protection level
    public class DerivedSingleto : Singleton
    {
    }
}
/*
 * The above error is because of the private constructor 
 * that we have in the Singleton class. Now you might be thinking 
 * that as we have a private constructor within the class so
 * it is not possible to derive this class, then why do we need to apply the sealed keyword to the Singleton class.
 * */
