using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FinalPhaseEndProject
{
    class TeacherFileSys
    {
        public static void Do()
        {
            ReadLine();

            bool flag = false;

            Console.WriteLine("\nDo you wanna enter new data:(Y/N)");
            string ans = Console.ReadLine();
            if (ans == "Y" || ans == "y")
            {
                flag = true;
                WriteLine(flag);
            }

        }

        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\RainbowSchoolTeacherData.txt";
            Console.WriteLine(filename);
            if (!File.Exists(filename))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                Console.WriteLine("\nFile exists\n");
                string[] contents = File.ReadAllLines(filename);

                int len = contents.Length;
                Console.WriteLine("Existing Teacher Data-- ");
                for (int i = 0; i < len; i++)
                {
                    string[] data = contents[i].Split(", ");
                    Console.WriteLine("ID: " + data[0] + ", Name: " + data[1] + ", Class and Section: " + data[2]);
                }

            }
        }
        private static void WriteLine(bool flag)
        {
            while (flag)
            {
                Teacher new_data = new Teacher();
                Console.WriteLine("\nEnter data:");
                var line = Console.ReadLine();
                var data = line.Split(", ");
                new_data.ID = Convert.ToInt32(data[0]);
                new_data.Name = data[1];
                new_data.ClassAndSection = data[2];

                string dir = Directory.GetCurrentDirectory();
                string filename = dir + "\\RainbowSchoolTeacherData.txt";
                Console.WriteLine(filename);
                if (File.Exists(filename))
                {
                    Console.WriteLine("File exists");
                    List<string> list = new List<string>();
                    list.Add(line);
                    File.AppendAllLines(filename, list);

                }

                Console.WriteLine("\nEntered!!\nDo you wanna enter new data again:(Y/N)");
                string res = Console.ReadLine();
                if (res == "Y" || res == "y")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

                ReadLine();

            }
        }

        /*private static void UpdateData()
        {

        }*/
        
    }

}
