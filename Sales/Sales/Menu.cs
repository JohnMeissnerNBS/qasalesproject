using System;
namespace Sales
{
    class Menu
    {
        private readonly MenuController menuController;

        public Menu()
        {
        }

        public Menu(MenuController menucontroller)
        {
            this.menuController = menucontroller;

        }

        public void PrintMenu()

        {
            {
                MainMenu();
            }

            static void MainMenu()
            {
                Console.WriteLine("=========== Main Menu ===========");

                Console.WriteLine("[1] Data Entry");
                Console.WriteLine("[2] Records");
                

                string choice = Console.ReadLine();
            

            int number;
            bool result = Int32.TryParse(choice, out number);

            if (result)
            {
                Console.Clear();
                SubMenu(number);
            }
            else
            {
                Console.WriteLine("invalid option");
            }

        }

        static void SubMenu(int mainMenuChoice)

        {
            switch (mainMenuChoice)
            {
                case 1:

                        MenuController.Create();
                        

                    break;

                case 2:

                    Console.WriteLine("Please select a records option");
                    Console.WriteLine("[1] Sales by Year");
                    Console.WriteLine("[2] Sales by Month and Year");
                    Console.WriteLine("[3] Total Sales by Year");
                    Console.WriteLine("[4] Total Sales by Year and Month");

                    break;

                





            }

            string choice = Console.ReadLine();

            int number;
            bool result = Int32.TryParse(choice, out number);
            if (result)
            {
                Action(mainMenuChoice, number);

            }
            else
            {
                Console.WriteLine("Incorrect choice");
            }

        }

        static void Action(int menu, int choice)
        {
            switch (menu)
            {

                case 2:

                    switch (choice)

                    {

                        case 1:
                                MenuController.ReadSalesbyyear();

                            break;

                        case 2:
                                MenuController.ReadSalesbymonthandyear();

                            break;

                        case 3:
                                MenuController.ReadTotalsalesbyyear();

                            break;

                        case 4:
                                MenuController.ReadTotalsalesbyyearandmonth();

                            break;

                    }

                    break;


            }
                


            



            }



        }


    }
}
