using System;
using Console_Application.Services;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selection;
            bool resault = false;
            Console.WriteLine("Course Managment Application");
            do
            {
                Console.WriteLine("\n1. Create Group");
                Console.WriteLine("2. Get All Group");
                Console.WriteLine("3. Edit Group");
                Console.WriteLine("4. Get Group Students");
                Console.WriteLine("5. GetAllStudent");
                Console.WriteLine("6. Created Student");
                Console.WriteLine("0. Exit");

                string strSelection = Console.ReadLine();
                resault = int.TryParse(strSelection, out selection);

                if (resault)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuServices.CreatedGroupMenu();
                            break;
                        case 2:
                                MenuServices.GetAllGroupMenu();
                            break ;
                            case 3:
                            MenuServices.EditGroupMenu();
                            break;
                        case 4:
                                MenuServices.GetGroupStudentsMenu();
                            break;
                        case 5:
                            MenuServices.GelAllStudentsMenu();
                            break;
                        case 6:
                            MenuServices.CreatedStudentMenu();
                            break ;
                        default:
                            Console.WriteLine("\nPlease choose valid number");
                            break;
                    }
                }
            } while (selection != 0 || resault==false);
        }

    }
}
