using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FinalPhaseEndProject
{
    class DataManipulation
    {

        public static string getDir()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\RainbowSchoolTeacherData.txt";
            return filename;
        }

        public static void ReadData()
        {
            string path = getDir();
            if (File.Exists(path))
            {
                string[] contents = File.ReadAllLines(path);
                int l = contents.Length;
                for (int i = 0; i < l; i++)
                {
                    string[] data = contents[i].Split(", ");
                    Console.WriteLine("ID: " + data[0] + ", Name: " + data[1] + ", Class and Section: " + data[2]);
                }

            }
        }

        public static void WriteData()
        {
            string path = getDir();
            if (File.Exists(path))
            {
                string res = Teacher.getData();
                List<string> list = new List<string>();
                list.Add(res);
                File.AppendAllLines(path, list);
            }
        }

        public static void UpdateData()
        {
            string path = getDir();
            if(File.Exists(path))
            {
                Console.WriteLine("\nEnter Id to be updated:");
                string new_id = Console.ReadLine();
                Teacher t = new Teacher();
                Console.WriteLine("Enter Id");
                t.Id = Console.ReadLine();
                Console.WriteLine("Enter Name");
                t.Name = Console.ReadLine();
                Console.WriteLine("Enter Class");
                t.Class = Console.ReadLine();
                string s = t.Id + ", " + t.Name + ", " + t.Class;
                string[] contents = File.ReadAllLines(path);
                StreamWriter wrt = File.CreateText(path);
                int l = contents.Length;
                for (int i = 0; i < l; i++)
                {
                    string[] data = contents[i].Split(", ");
                    if(data[0] == new_id)
                    {
                        wrt.WriteLine(data[0] + ", " + t.Name + ", " + t.Class);
                    }
                    else
                    {
                        wrt.WriteLine(data[0] + ", " + data[1] + ", " + data[2]);
                    }
                }
                wrt.Close();
            }
        }
    }
}
