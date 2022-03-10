using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstractlar da classdır interface gibi değil -Abstractlar interface ile virtual metodun birleşimi - Abstract içi dolu olmayan virtual metoddur

            Database database = new Oracle();
            database.Add();
            database.Delete();
            Database database1 = new SqlServer();
            database.Add();
            database.Delete();


            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()    //tamamlanmış metod
        {
            Console.WriteLine("Added By Default");
        }

        public abstract void Delete(); // tamamlanmamış metod -- abstractde hem tamamlanmış hem de tamamlanmamış metod kullanılabilir
        
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
