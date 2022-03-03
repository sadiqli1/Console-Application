using System;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Isa Sadiqli","P127",true);
            student.CheckFullname("Isa Sadiqli");
        }
    }
}
