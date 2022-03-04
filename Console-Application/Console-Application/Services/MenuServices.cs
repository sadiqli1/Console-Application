using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Services
{
    static class MenuServices
    {
        public static CourseServices courseservices = new CourseServices();

        public static void CreatedGroupMenu()
        {
            Console.WriteLine("is Group online?(true/false)");
            bool isonline;
            string isonlineStr = Console.ReadLine();
            bool resaultIsonline = bool.TryParse(isonlineStr, out isonline);
            if (resaultIsonline)
            {
                Console.WriteLine("Please choose category");
                foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
                {
                    Console.WriteLine($"{(int)c}. {c}");
                }
                int category;
                string catStr = Console.ReadLine();
                bool resultCat = int.TryParse(catStr, out category);
                if (resultCat) 
                {
                    switch (category)
                    {
                        case (int)Categories.Programing:
                            string No = courseservices.CreatedGroup(Categories.Programing, isonline);
                            Console.WriteLine($"{No} Group succesfully created");
                            break;
                        case (int)Categories.Design:
                            No = courseservices.CreatedGroup(Categories.Design, isonline);
                            Console.WriteLine($"{No} Group succesfully created");
                            break;
                        case (int)Categories.System_Administration:
                            No = courseservices.CreatedGroup(Categories.System_Administration, isonline);
                            Console.WriteLine($"{No} Group succesfully created");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose valid category");
                }
            }
            else
            {
                Console.WriteLine("Please chose valid is online(true\false)");
            }
        }

        internal static void EditHallMenu()
        {
            throw new NotImplementedException();
        }

        public static void GetAllGroupMenu()
        {
            courseservices.GetAllGroup();
        }
        public static void CreatedStudentMenu()
        {
            bool resault=false;
            do
            {
                Console.WriteLine("Please write name and surname(Example:Barack Obama)");
                string fullname = Console.ReadLine();
                string[] fulnamestr = fullname.Split(" ");
                foreach (string item in fulnamestr)
                {
                    if (char.IsUpper(item[0]))
                    {
                        resault = true;
                    }
                    else
                    {
                        resault = false;
                        break;
                    }
                }
            } while (resault == false);
            bool resault1;
            Console.WriteLine("Please write groupno");
            do
            {
                string groupno = Console.ReadLine();
                bool hasupper1 = false;
                bool hasdigit1 = false;
                if (groupno.Length == 4)
                {
                    for (int i = 0; i < groupno.Length; i++)
                    {
                        if (char.IsUpper(groupno[0]) && char.IsDigit(groupno[i]))
                        {
                            hasupper1 = true;
                            hasdigit1 = true;
                        }
                    }
                    Console.WriteLine("Please chosse correct groupno");
                }
                else
                {
                    Console.WriteLine("Please chosse correct groupno");
                }
                resault1 = hasupper1 && hasdigit1;
            } while (resault1==false);
            bool resaultiswarranted;
            do
            {
                Console.WriteLine("is warranted student?");
                bool iswarranted;
                string iswarrantedstr = Console.ReadLine();
                resaultiswarranted = bool.TryParse(iswarrantedstr, out iswarranted);
            } while (resaultiswarranted==false);
        }
    }
}
