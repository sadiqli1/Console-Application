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
            bool resaultnum = false;
            do
            {
                Console.WriteLine("Please choose category");
                foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
                {
                    Console.WriteLine($"{(int)c}. {c}");
                }
                catStr = Console.ReadLine();
                resaultCat = int.TryParse(catStr, out category);
                resaultnum = catStr == "1" || catStr == "2" || catStr == "3";
            } while (resaultCat == false || resaultnum==false) ;

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
            Console.WriteLine("Please choose group no");
            string no = Console.ReadLine();
            Console.WriteLine("Please choose new group no");
            string newno = Console.ReadLine();
            courseservices.EditGroup(no, newno);
            //string newno;
            //bool resault2 = false;
            //bool hasupper2 = false;
            //bool hasdigit2 = false;
            //do
            //{
            //    Console.WriteLine("Please choose new group no");
            //    newno = Console.ReadLine();
            //    if (newno.Length == 4)
            //    {
            //        if (char.IsUpper(newno[0]))
            //        {
            //            hasupper2 = true;
            //            for (int i = 1; i < newno.Length; i++)
            //            {
            //                if (char.IsDigit(newno[i]))
            //                {
            //                    hasdigit2 = true;
            //                }
            //                else
            //                {
            //                    hasdigit2 = false;
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            hasupper2 = false;
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        resault2 = false;
            //        break;
            //    }
            //    resault2 = hasdigit2 && hasupper2;

            //} while (resault2 == false);
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
                        hasupper1 = true;
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
                Console.WriteLine("is warranted student? (yes/no)");
                string iswarrantedstr = Console.ReadLine();
                if (iswarrantedstr=="yes")
                {
                    iswarrantedstr = "true";
                }
                else if (iswarrantedstr=="no")
                {
                    iswarrantedstr = "true";
                }
                resaultiswarranted = bool.TryParse(iswarrantedstr, out iswarranted);
            } while (resaultiswarranted==false);
            courseservices.CreatedStudents(fullname,groupno,iswarranted);
        }
    }
}
