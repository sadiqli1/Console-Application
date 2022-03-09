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
            Console.WriteLine("Please enter group no");
            string no = Console.ReadLine();
            Check.Check.CheckGroupNo(no);
            Console.WriteLine("Please enter new group no");
            string newno = Console.ReadLine();
            Check.Check.CheckGroupNo(newno);
            courseservices.EditGroup(no, newno);
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

            Console.WriteLine("Please write name and surname(Example:Barack Obama)");
            string fullname = Console.ReadLine();
            Check.Check.CheckFullname(fullname);

            Console.WriteLine("Please write groupno");
            string groupno = Console.ReadLine();
            Check.Check.CheckGroupNo(groupno);

            bool resaultiswarranted;
            bool iswarranted;
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
                    iswarrantedstr = "false";
                }
                resaultiswarranted = bool.TryParse(iswarrantedstr, out iswarranted);
            } while (resaultiswarranted==false);
            courseservices.CreatedStudents(fullname,groupno,iswarranted);
            
        }
    }
}
