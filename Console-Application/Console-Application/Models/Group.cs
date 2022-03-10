using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Group
    {
        public static int count=100;
        public static int count1 = 100;
        public static int count2 = 100;
        public string No;
        public Categories Category;
        public static bool isOnline;
        public int Limit;
        public List<Student> Students;

        public Group(Categories category,bool isonline)
        {
            Students = new List<Student>();
            switch (category) 
            {
                case Categories.Programing:
                    No = $"P{count}";
                    count++;
                    break;
                case Categories.Design:
                    No = $"D{count1}";
                    count1++;
                    break;
                case Categories.System_Administration:
                    No = $"S{count2}";
                    count2++;
                    break;
                default:
                    break;
            }
            Category = category;
            if (isonline==true)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }
        }
        public override string ToString()
        {
            return $"No:{No},Category:{Category},Limit:{Limit}";
        }
    }
}
