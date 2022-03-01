using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = 220;
            //if (number == 10)
            //{
            //    Console.WriteLine("sayı 10'dur.");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("sayı 20'dir.");
            //}

            //else
            //{
            //    Console.WriteLine("sayı 10 değil");
            //}

            //Console.ReadLine();

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("sayı 10'dur.");
            //        break;
            //    case 20:
            //        Console.WriteLine("sayı 20");
            //        break;
            //    default:
            //        Console.WriteLine("hiçbiri değil lo");
            //        break;
            //}
            //Console.ReadLine();

            string nickname, parola;

            Console.WriteLine("kullanıcı adını gir:");
            nickname = Console.ReadLine();
            Console.WriteLine("parolanı gir");
            parola = Console.ReadLine();
            if (nickname == "sskhan"&& parola == "allah1dir")
            {
                Console.WriteLine("giriş başarılı");

            }
            else
            {
                Console.WriteLine("nickname veya parola hatali");
            }

            Console.ReadLine();

        }
    }
}
