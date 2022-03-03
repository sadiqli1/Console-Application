using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Interface
{
    interface ICourseService
    {
        public List<Group> Groups { get; }
        public string CreatedGroup();
        public void GetAllGroup();
        public void EditGroup();
        public void GetGroupStudents();
        public void GetAllStudent();
        public string CreatedStudents();

    }
}
