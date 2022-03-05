using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Interface
{
    interface ICourseService
    {
        public List<Group> Groups { get; }
        public string CreatedGroup(Categories categories, bool isonline);
        public void GetAllGroup();
        public void EditGroup(string no, string newno);
        public void GetGroupStudents(string no);
        public void GetAllStudent();
        public string CreatedStudents(string fullname, string groupno, bool iswarranted);

    }
}
