﻿using System;
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
            group.Students = new List<Student>();
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
        public void EditGroup(string no, string newno)
        {
            Group existedGroup = FindGroup(no);
            if (existedGroup == null)
            {
                Console.WriteLine("Please choose correct group no");
                return;
            }
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == newno.ToLower().Trim())
                {
                    Console.WriteLine($"{newno} group already exist");
                    return;
                }
            }
            existedGroup.No = newno.ToUpper();
            Console.WriteLine($"{no} group succesfully change to {newno}");
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
            //Group group = Groups.Find(x=>x.No.Trim().ToLower() == no.Trim().ToLower());

            //if (Groups.Count==0)
            //{
            //    Console.WriteLine("Error");
            //}
            if (group == null)
            {
                Console.WriteLine("Please choose valid group no");
            }
            else if (Groups.Count==0)
            {
                Console.WriteLine("Free group");
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
                Group _group = Groups.Find(x => x.No.Trim().ToLower() == groupno.Trim().ToLower());
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
            Group group = Groups.Find(x => x.No.Trim().ToLower() == groupno.Trim().ToLower());
            group.Students.Add(student);
            Students.Add(student);
            return student.GroupNo;
        }
    }
}
