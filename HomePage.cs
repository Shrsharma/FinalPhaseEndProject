using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPhaseEndProject
{
    class HomePage
    {
        public static void Do()
        {
            Console.WriteLine("~~~This is Home Page~~~.\n\n Do you wanna do something?(Y/N):");
            string ans = Console.ReadLine();
            bool flag = false;
            if (ans == "Y" || ans == "Y")
            {
                flag = true;

                while (flag)
                {
                    Console.WriteLine("\n 1)Do you wanna display data  \n 2)Do you wanna add new data \n 3)Do you wanna update the data");
                    string res = Console.ReadLine();
                    if (res == "1")
                    {
                        DataManipulation.ReadData();
                    }
                    else if (res == "2")
                    {
                        DataManipulation.WriteData();
                    }
                    else if(res == "3")
                    {
                        DataManipulation.UpdateData();
                    }
                    else
                    {
                        Console.WriteLine("\n~~~No such option~~~");
                    }
                    Console.WriteLine("\nDo you wanna do anything more?(Y/N):");
                    string ask = Console.ReadLine();
                    if (ask == "Y" || ask == "y")
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }

                }
            }
            Console.WriteLine("~~~THE END~~~");
        }

    }
}
