using System;
using Owoda.Models;

namespace Owoda
{
    class Program
    {
        static void Main(string[] args)
        {
            OwodaApp App = new OwodaApp();

            Console.WriteLine("Welcome to Owoda! Pick an option");

            App.InitializeApp();
        }
    }
}
