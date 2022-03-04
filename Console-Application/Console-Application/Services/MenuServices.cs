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

        public static void EditGroupMenu()
        {
            //Console.WriteLine("Please choose group no");
            //string No = Console.ReadLine();
            //Console.WriteLine("Please choose new group no");
            //string NewNo = Console.ReadLine();
            //CourseServices.EditGroup(No,NewNo);
        }
        public static void GetGroupStudentsMenu()
        {
            Console.WriteLine("Please choose group no");
            string no = Console.ReadLine();
            courseservices.GetGroupStudents(no);
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
                    for (int i = 1; i < item.Length; i++)
                    {
                        if (char.IsDigit(item[i]))
                        {
                            resault = true;
                        }
                        else
                        {
                            resault = false;
                        }
                    }
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
            bool resault1=false;
            do
            {
                Console.WriteLine("Please write groupno");
                string groupno = Console.ReadLine();
                if (groupno.Length == 4)
                {
                    if (char.IsUpper(groupno[0]))
                    {
                        resault1 = true;
                        for (int i = 1; i < groupno.Length; i++)
                        {
                            if (char.IsDigit(groupno[i]))
                            {
                                resault1 = true;
                            }
                            else
                            {
                                resault1 = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        resault1 = false;
                        break;
                    }
                }
                else
                {
                    resault1 = false;
                    break;
                }
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
