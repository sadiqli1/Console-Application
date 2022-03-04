using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Group
    {
        public static int count=100;
        public string No;
        public Categories Category;
        public bool isOnline;
        public int Limit;
        public Student[] Students;

        public Group(Categories category,bool isonline)
        {
            switch (category) 
            {
                case Categories.Programing:
                    No = $"P{count}";
                    break;
                case Categories.Design:
                    No = $"D{count}";
                    break;
                case Categories.System_Administration:
                    No = $"SA{count}";
                    break;
                default:
                    break;
            }
            Category = category;
            count++;
            if (isonline==true)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }

        }
    }
}
