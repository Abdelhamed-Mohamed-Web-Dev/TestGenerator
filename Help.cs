using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project_02
{
    internal class Help
    {
        public static int ReadInt() // Any int
        {
            bool flag = false;
            int x = 0;
            while (!flag)
            {
                flag = int.TryParse(Console.ReadLine(), out x);
                
                if (!flag)
                    Console.Write("Invalid Number\nTry Again : ");
            }
            return x;
        }
        public static int ReadInt(int s ,int e) // With interval 
        {
            int x = 0;
            while (true) // Ensure that the num = 1 | 2
            {
                x = Help.ReadInt();
                if (x >= s && x <= e)
                    break;
                Console.WriteLine("Invalid Option\nTry Again");
            }
            return x;
        }
    }
}
