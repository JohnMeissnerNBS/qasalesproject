using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {

            Records record1 = new Records();

            Console.WriteLine("Hello please type Data Entry or Records");
            string input = Console.ReadLine();



            switch (input)
            {
                case "Data Entry":

                    {
                        Console.WriteLine("hello");
                    }

                    break;

                case "Records":

                    {
                        Console.WriteLine("");
                    }

                    break;

                default:

                    {
                        Console.WriteLine("Invalid Selection");

                    }

                    break;

            }
        }
    }
}