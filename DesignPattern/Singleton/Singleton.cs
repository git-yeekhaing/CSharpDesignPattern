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

        private static readonly Lazy<Singleton> Instancelock = new Lazy<Singleton>(() => new Singleton());
       
        public static Singleton GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }        

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
/*
This is because of the lazy keyword which creates only one singleton instance 
and also they are by default thread-safe that’s why we do not get 
any error while invoking the methods parallelly.
*/
