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

        private List<Student> _students = new List<Student>();
        public List<Student> Students => _students;

        public string CreatedGroup(Categories categories,bool isonline)
        {
            Group group = new Group(categories,isonline);
            Groups.Add(group);
            return group.No;
        }
        public void GetAllGroup()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("There is no Group");
            }
            foreach (Group group in Groups)
            {
                Console.WriteLine(group);
            }
        }
        //public void EditGroup(string no, string newno)
        //{
        //    Group existedGroup = FindGroup(no); 
        //    if (existedGroup == null)
        //    {
        //        Console.WriteLine("Please choose correct group no");
        //    }
        //}
        public Group FindGroup(string no)
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }
        public void GetGroupStudents(string no)
        {
            Group group = FindGroup(no);
            if (group==null)
            {
                Console.WriteLine("Please choose valid group no");
            }
            foreach (Student student in group.Students)
            {
                Console.WriteLine(student);
            }
        }
        public void GetAllStudent()
        {
            throw new NotImplementedException();
        }
        public void EditGroup()
        {
            throw new NotImplementedException();
        }

        public void GetGroupStudents()
        {
            throw new NotImplementedException();
        }

        public string CreatedStudents(string fullname, string groupno, bool iswarranted)
        {
            Student student = new Student(fullname, groupno, iswarranted);
            Students.Add(student);
            return student.GroupNo;
        }
    }
}
