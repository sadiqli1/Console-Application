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
            Group existedGraoup = FindGroup(group.No);
            if (existedGraoup==null)
            {
                Groups.Add(group);
            }
            else
            {
                if (group.No[0].ToString().ToLower()=="p")
                {
                    Group.count++;
                    group.No= $"P{Group.count}";
                    Groups.Add(group);
                }
                else if (group.No[0].ToString().ToLower() == "d")
                {
                    Group.count1++;
                    group.No=$"D{Group.count1}";
                    Groups.Add(group);
                }
                else if (group.No[0].ToString().ToLower() == "s")
                {
                    Group.count2++;
                    group.No=$"S{Group.count2}";
                    Groups.Add(group);
                }
            }
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
        public void EditGroup(string no, string newno)
        {
            Group existedGroup = FindGroup(no);
            if (existedGroup == null)
            {
                Console.WriteLine("There is no group");
            }

            foreach (Group group in Groups)
            {
                
                while (group.No.ToLower().Trim() == newno.ToLower().Trim())
                {
                    Console.WriteLine($"{newno} group already exist");
                    newno = Console.ReadLine();
                }
            }
            foreach (Group item in Groups)
            {
                if (item.No==no)
                {
                    if (no[0]==newno[0])
                    {
                        item.No = newno;
                        Console.WriteLine($"{no} group succesfully change to {newno}");
                    }
                    else
                    {
                        Console.WriteLine("Not the same category");
                    }
                }
            }
        }
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
            if (group == null)
            {
                Console.WriteLine("Please choose valid group no");
            }
            else if (Students.Count==0)
            {
                Console.WriteLine("Empty group");
            }
            else
            {
                foreach (Student student in group.Students)
                {
                    Console.WriteLine(student);
                }
            }
        }
        public void GetAllStudent()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }
        public string CreatedStudents(string fullname, string groupno, bool iswarranted)
        {
            Student student = new Student(fullname, groupno, iswarranted);
            if (groupno!=null)
            {
                Group _group = FindGroup(groupno);
                if (_group != null)
                {
                    _group.Students.Add(student);
                    Console.WriteLine("\nStudent created");
                }
                else
                {
                    Console.WriteLine("Group not exist");
                    return "";
                }
            }
            Group group = FindGroup(groupno);
            if (group.Students.Count<=group.Limit)
            {
                Students.Add(student);
                group.Students.Add(student);
            }
            else
            {
                Console.WriteLine("Group is full");
            }
            return student.GroupNo;
        }
    }
}
