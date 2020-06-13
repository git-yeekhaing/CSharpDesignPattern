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
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
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
}
/*
 In the Double-checked locking mechanism,
first, we will check whether the instance is created or not.
If not then only we will synchronize the method
*/
