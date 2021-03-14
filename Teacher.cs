using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPhaseEndProject
{
    class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }

        public static string getData()
        {

            Teacher t = new Teacher();
            Console.WriteLine("Enter Id");
            t.Id = Console.ReadLine();
            Console.WriteLine("Enter Name");
            t.Name = Console.ReadLine();
            Console.WriteLine("Enter Class");
            t.Class = Console.ReadLine();
            Console.WriteLine(t.Id + ", " + t.Name + ", " + t.Class);
            string s = t.Id + ", " + t.Name + ", " + t.Class;
            return s;
        }
    }
}
