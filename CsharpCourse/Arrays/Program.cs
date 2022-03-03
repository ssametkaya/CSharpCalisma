using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students1 = new string[4];
            students1[0] = "samet";
            students1[1] = "ahmet";
            students1[2] = "mehmet";
            students1[3] = "anıl";

            //string[] students = new[] { "anıl", "ahmet", "mehmet", "samaet" };

            string[] students = { "anıl", "ahmet", "memet", "sameteee" };
            
            foreach (var student in students1)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
    }
}
