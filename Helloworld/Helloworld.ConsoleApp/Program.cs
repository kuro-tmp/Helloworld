
namespace Helloworld.ConsoleApp
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            new ConsoleRunner().Run(() =>
            {
                Console.WriteLine("");
            });
        }
    }

    public class ConsoleRunner
    {
        public void Run(Action action)
        {
            action.Invoke();
        }
    }
}
