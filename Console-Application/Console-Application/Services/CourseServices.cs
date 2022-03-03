using System;
using System.Collections.Generic;
using System.Text;
using Console_Application.Interface;

namespace Console_Application.Services
{
    class CourseServices : ICourseService
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        public string CreatedGroup(string no, Categories categories,bool isonline)
        {
            Group group = new Group(no,categories,isonline);
            Groups.Add(group);
            return group.No;
        }

        public string CreatedStudents()
        {
            throw new NotImplementedException();
        }

        public void EditGroup()
        {
            throw new NotImplementedException();
        }

        public void GetAllGroup()
        {
            throw new NotImplementedException();
        }

        public void GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public void GetGroupStudents()
        {
            throw new NotImplementedException();
        }
    }
}
