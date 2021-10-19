using System;
namespace Sales
{
    class Menu
    {
        private readonly MenuController menuController;

        public Menu(MenuController menucontroller)
        {
            this.menuController = menucontroller;

        }

        public void PrintMenu()

        {
            //provide user with menu options
            Console.WriteLine("Hello please type Data Entry or Records");
            // read user input
            string input = Console.ReadLine();




            switch (input)
            {
                case "Data Entry" or "data entry":


                    {
                        Console.WriteLine("hello");
                        MenuController.create();
                    }

                    break;

                case "Records" or "records":

                    {

                        Console.WriteLine("Please type either Sales by year, Sales by month and year, Total sales by year or Total sales by year and month");
                        



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
