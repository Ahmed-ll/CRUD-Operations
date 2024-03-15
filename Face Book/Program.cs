namespace Face_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            All_Functions();
        }

        static void All_Functions()
        {
            bool Done = false;
            while (!Done)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Welcome to Our Face Book App \n");
                Console.Write("[1] Add User \t");
                Console.Write("[2] View Data \t");
                Console.Write("[3] Update Data \t");
                Console.Write("[4] Delete User \t");
                Console.Write("[5] Exit \t");

                Console.WriteLine("\n______________________________\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Please Select an Option : ");
                string option = Console.ReadLine();

                Console.WriteLine("______________________________\n");


                Operations operation = new User_Functions();

                switch (option)
                {
                    case "1":
                        operation.Add_User();
                        break;

                    case "2":
                        operation.View_Info();
                        break;

                    case "3":
                        operation.Update_Info();
                        break;

                    case "4":
                        operation.Delete_User();
                        break;

                    case "5":
                        Done = true;
                        Console.Clear();
                        Console.WriteLine("Thank You and Good Bye! \n");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option, Please Try Again!   \n");
                        break;

                }
            }
        }

        
    }
}

