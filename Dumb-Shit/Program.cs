using System;

namespace Dumb_Shit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you?");
            string userStatus = Console.ReadLine();
            switch (userStatus.ToLower())
            {
                case "good":
                    Console.WriteLine("Great I'm glad you're good.");
                    break;
                case "bad":
                    Console.WriteLine("Oh, I'm sorry to hear that.");
                    break;
                case "":
                    Console.WriteLine("Fine then, keep your secrets.");
                    break;
                default:
                    Console.WriteLine("Alright.");
                    break;
            }
        }
    }
}