using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool isWarranted;
        public Student(string fullname,string groupno,bool iswaranted)
        {
            Fullname = fullname;
            GroupNo = groupno; 
            isWarranted = iswaranted;
        }
        public override string ToString()
        {
            return $"FullName:{Fullname},GroupNo:{GroupNo}";

        }

    }
}
