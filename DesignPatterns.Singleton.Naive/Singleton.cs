using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.Naive
{
    // The Singleton class defines the `GetInstance` method that serves as an
    // alternative to constructor and lets clients access the same instance of
    // this class over and over.
    public class Singleton
    {
        // The Singleton's instance is stored in a static field. 
        private static Singleton _instance;

        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private Singleton() {}

        public static Singleton GetInstance()
        {
            if (_instance is null)
                _instance = new Singleton();

            return _instance;
        }

        public static void PerformHardcoreBusinessLogic()
        {
            Console.WriteLine("Performing hardcore business logic!");
        }
    }
}
