namespace Face_Book
{
    class User_Functions : Operations
    {
        static List<User> DB = new List<User>();
        public override void Add_User()
        {
            Console.Clear();

            Console.WriteLine("         Add New User             ");
            Console.WriteLine("                                  ");

    
            int Id = EnterInt("Enter ID of User: ");

            Console.Write("Enter Your Name : ");
            string Name = EnterString(Console.ReadLine());

            int Age = EnterInt("Enter Your Age : ");

            Console.Write("Enter Your Address : ");
            string Address = EnterString(Console.ReadLine());

            Console.Write("Enter Your Email : ");
            string Email = EnterString(Console.ReadLine());

            User obj = new(Id, Name, Age, Address, Email);

            DB.Add(obj);

            Console.Clear();

            View_Info();

            Console.WriteLine("User is added successfully.");
            Console.WriteLine("___________________________\n");
        }
        public override void View_Info()
        {
            Console.WriteLine("         View User                ");
            Console.WriteLine("                                  ");


            if (DB.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No User Yet , Please Add New User. \n");
                return;
            }

            var Accounts = DB;

            Console.Clear();
            foreach (var account in Accounts)
            {
                Console.WriteLine("Id : " + account.Id + "\n");
                Console.WriteLine("Name : " + account.Name + "\n");
                Console.WriteLine("Age : " + account.Age + "\n");
                Console.WriteLine("Address : " + account.Address + "\n");
                Console.WriteLine("Email : " + account.Email + "\n");
                Console.Write("\n");
            }

        }
        public override void Update_Info()
        {
            Console.Clear();

            Console.WriteLine("         Update User              ");
            Console.WriteLine("                                  ");


            int Id = EnterInt("Enter ID of User: ");

            var Target = DB.Find(x => x.Id == Id);

            if (Target == null)
            {
                Console.Clear();
                Console.WriteLine("User is not Found. \n");
                return;
            }
                Console.WriteLine();
                Console.Write("[1] Update ID \t");
                Console.Write("[2] Update Name \t");
                Console.Write("[3] Update Age \t");
                Console.Write("[4] Update Address \t");
                Console.Write("[5] Update Email \t");
                Console.Write("[6] Exit \n\n");

            
                Console.Write("Select an Option : ");
                string option = Console.ReadLine();

                Console.WriteLine("                   ");

                switch (option)
                {

                    case "1":
                        int id = EnterInt("Enter New ID: ");
                        Target.Id = id;
                        break;

                    case "2":
                        Console.Write("Enter New Name : ");
                        string name = EnterString(Console.ReadLine());
                        Target.Name = name;
                        break;

                    case "3":
                        int age = EnterInt("Enter New Age: ");
                        Target.Age = age;
                        break;

                    case "4": 
                        Console.Write("Enter New Address : ");
                        string address = EnterString(Console.ReadLine());
                        Target.Address = address;
                        break;

                    case "5":
                        Console.Write("Enter New Email : ");
                        string email = EnterString(Console.ReadLine());
                        Target.Email = email;
                        break;

                    case "6":
                        break;

                    default:
                        Console.WriteLine("Invalid option. \n");
                        break;
                }

            Console.Clear();

            View_Info();

            Console.WriteLine("Information is updated successfully.");
            Console.WriteLine("____________________________________\n");

        }
        public override void Delete_User()
        {
            Console.WriteLine("         Delete User              ");
            Console.WriteLine("                                  ");

            int Id = EnterInt("Enter ID of User: ");


            var Target = DB.Find(x => x.Id == Id);
            if (Target == null)
            {
                Console.Clear();
                Console.WriteLine("User is not Found. \n");
                return;
            }

            DB.Remove(Target);
            Console.Clear();
            Console.WriteLine("User is deleted successfully.");
            Console.WriteLine("_____________________________\n");
         
        }
        public override int EnterInt(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;
                else
                    Console.WriteLine("Invalid input , Try Again. \n");
            }
        }
        public override string EnterString( string input)
        {
            while (true)
            {
                bool Letters_Only = true;
                foreach (char ch in input)
                {
                    if (!char.IsLetter(ch))
                    {
                        Letters_Only = false;
                        break;
                    }
                }

                if (Letters_Only)
                    return input;
                else
                    Console.WriteLine("Invalid input , Try Again. \n");

                input = Console.ReadLine(); 
            }
        }
    }
}

