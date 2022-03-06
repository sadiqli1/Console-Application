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
            bool resaultIsonline = false;
            bool isonline;
            do
            {
                Console.WriteLine("is Group online? (yes or no)");
                string isonlineStr = Console.ReadLine();
                if (isonlineStr == "yes")
                {
                    isonlineStr = "true";
                }
                else if (isonlineStr == "no")
                {
                    isonlineStr = "false";
                }
                resaultIsonline = bool.TryParse(isonlineStr, out isonline);
            } while (resaultIsonline == false);

            bool resaultCat = false;
            int category;
            string catStr;
            do
            {
                Console.WriteLine("Please choose category");
                foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
                {
                    Console.WriteLine($"{(int)c}. {c}");
                }
                catStr = Console.ReadLine();
                resaultCat = int.TryParse(catStr, out category);
            } while (resaultCat == false) ;

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
        public static void GetAllGroupMenu()
        {
            courseservices.GetAllGroup();
        }
        public static void EditGroupMenu()
        {
            //Group group1 = courseservices.Groups.Find(x => x.No == no);
            Console.WriteLine("Please choose group no");
            string No = Console.ReadLine();
            Console.WriteLine("Please choose new group no");
            string NewNo = Console.ReadLine();
            courseservices.EditGroup(No,NewNo);
        }
        public static void GetGroupStudentsMenu()
        {
            Console.WriteLine("Please choose group no");
            string no = Console.ReadLine();
            courseservices.GetGroupStudents(no);
        }
        public static void GelAllStudentsMenu() 
        {
            courseservices.GetAllStudent();
        }
        public static void CreatedStudentMenu()
        {
            bool resault=false;
            string groupno;
            bool iswarranted;
            string fullname;
            bool hasupper = false;
            bool haslower = false;
            bool hasdigit = false;
            do
            {
                Console.WriteLine("Please write name and surname(Example:Barack Obama)");
                fullname = Console.ReadLine();
                
                string[] fulnamestr = fullname.Split(" ");
                foreach (string item in fulnamestr)
                {
                    if (char.IsUpper(item[0]))
                    {
                        hasupper = true;
                    }
                    else
                    {
                        hasupper = false;
                        break;
                    }
                    for (int i = 1; i < item.Length; i++)
                    {
                        if (char.IsLower(item[i])&&!char.IsDigit(item[i]))
                        {
                            haslower = true;
                            hasdigit = true;
                        }
                        else
                        {
                            haslower = false;
                            hasdigit = false;
                            break ;
                        }
                    }
                }
                resault = hasupper && haslower && hasdigit;
            } while (resault == false);
            bool resault1 = false;
            bool hasupper1 = false;
            bool hasdigit1 = false;
            do
            {
                Console.WriteLine("Please write groupno");
                groupno = Console.ReadLine();
                if (groupno.Length == 4)
                {
                    if (char.IsUpper(groupno[0]))
                    {
                        resault1 = true;
                        for (int i = 1; i < groupno.Length; i++)
                        {
                            if (char.IsDigit(groupno[i]))
                            {
                                hasdigit1 = true;
                            }
                            else
                            {
                                hasdigit1 = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        hasupper1 = false;
                        
                    }
                }
                else
                {
                    resault1 = false;
                }
                resault1 = hasupper1 && hasdigit1;
            } while (resault1 == false);
            bool resaultiswarranted;
            do
            {
                Console.WriteLine("is warranted student?");
                string iswarrantedstr = Console.ReadLine();
                resaultiswarranted = bool.TryParse(iswarrantedstr, out iswarranted);
            } while (resaultiswarranted==false);
            courseservices.CreatedStudents(fullname,groupno,iswarranted);
        }
    }
}
