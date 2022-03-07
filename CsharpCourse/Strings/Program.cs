using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    //class Program
    //{
    //static void Main(string[] args)
    //{
    //    //string city = "Ordu";

    //    ////Console.WriteLine(city[0]);

    //    ////String bir veri tipidir. Bir de char arrayidir.

    //    //foreach (var item in city)
    //    //{
    //    //    Console.WriteLine(item);
    //    //}

    //    //string city2 = "Isparta";
    //    //string city3 = "Van";
    //    ////string result = city + city2 + city3;

    //    ////Console.WriteLine(result);

    //    //Console.WriteLine(String.Format("{0} {1} {2}", city, city2, city3)); //result diye bir değisken atamamak için bu sekilde yazabiliriz
    //    //Console.ReadLine(); 

    //    string sentence = "my name is SAMET";

    //    var result = sentence.Length;
    //    //var result2 = sentence.Clone();

    //    //sentence = "my name is yigit";

    //    //bool result3 = sentence.EndsWith("t");
    //    bool result3 = sentence.EndsWith("t");

    //    //bool result4 = sentence.StartsWith("m");
    //    bool result4 = sentence.StartsWith("my name");

    //    var result5 = sentence.IndexOf("samet");
    //    var result6 = sentence.IndexOf(" ");
    //    var result7 = sentence.LastIndexOf(" ");
    //    var result8 = sentence.Insert(0, "Hello, ");
    //    var result9 = sentence.Substring(3,4);
    //    var result10 = sentence.ToLower();
    //    var result11 = sentence.ToUpper();
    //    var result12 = sentence.Replace(" ", "??");
    //    //var result13 = sentence.Remove(2);
    //    var result13 = sentence.Remove(2,5);

    //    Console.WriteLine(result13);
    //    Console.ReadLine();


    class Program
    {
        //public static void Main(string[] args)
        //{

        //    Console.Write("1. metni giriniz: ");
        //    string metin1 = Console.ReadLine();

        //    Console.Write("2. metni giriniz: ");
        //    string metin2 = Console.ReadLine();

        //    int donusDegeri = String.Compare(metin1, metin2);
        //    Console.WriteLine(donusDegeri);

        //    Console.ReadKey();
        //}

        public static void Main(string[] args)
        {

            Console.Write("1. metni giriniz: ");
            string metin1 = Console.ReadLine();

            Console.Write("2. metni giriniz: ");
            string metin2 = Console.ReadLine();

            string birles = String.Concat(metin1, metin2);

            Console.WriteLine("{0} ve {1} kelimelerinin birleştirilmiş hali: {2}", metin1, metin2, birles);

            Console.ReadKey();
        }



    }
}
