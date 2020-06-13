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

            Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
            derivedObj.PrintDetails("From Derived");

            Console.ReadLine();
        }
    }
}
/*
The above output clearly shows that the counter value
has incremented to 2 which proves that the private constructor 
executed twice and hence it creates multiple instances of the 
singleton class. So, by removing the sealed keyword we can inherit 
the singleton class and also possible to create multiple objects 
of the singleton class. This violates singleton design principles.
 */
