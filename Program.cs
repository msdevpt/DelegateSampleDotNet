using System;

namespace DelegateSample
{
    class Program
    {
        private delegate void GreetingDelegate(string msgString);

        private static void GoodMorning(string yourName)
        {
            Console.WriteLine("Good Morning " + yourName + " !");
        }
        private static void GoodNight(string yourName)
        {
            Console.WriteLine("Good Night " + yourName + " !");
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Adding 'GoodMoring' Reference to a Delegate...");
            GreetingDelegate myGreeting = GoodMorning;

            // invoking the delegate
            Console.WriteLine("Invokin Delegate...");
            myGreeting.Invoke("MS");

            // Assiging the addressof the another function to the same delegate
            Console.WriteLine();
            Console.WriteLine("Making Existing Delegate To Point To Another Fuction...");
            Console.WriteLine("Replacing With 'GoodNight' Reference...");
            myGreeting = new GreetingDelegate(GoodNight);

            // Another way of invoking the delegate
            Console.WriteLine("Invoking Delegate...");
            myGreeting("SM");

        }
    }
}
