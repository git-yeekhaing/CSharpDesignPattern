using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();
        }
    }
}
/*The way we implement the singleton design pattern 
 * in the above example is not to thread-safe.
 * It means in a multithreaded environment,
 * it will able to create multiple instances of the singleton
 * class. How to make the singleton class thread-safe we will discuss
 * in the Thread-Safe Singleton Design Pattern article.
 * */
