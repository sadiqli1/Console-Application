using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool Type;
        public Student(string fullname,string groupno,bool type)
        {
            Fullname = fullname;
            GroupNo = groupno; 
            Type = type;
        }
        public void CheckFullname(string fullname)
        {
            fullname = fullname.Trim();
            string[] arr = fullname.Split(' ');
            if (arr.Length==2)
            {
                foreach (string item in arr)
                {
                    if (char.IsUpper(item[0]))
                    {
                        Fullname = fullname;
                    }
                    else
                    {
                        Console.WriteLine("Please enter choose name and surname");
                    }
                }
            }
        }
    }
}
