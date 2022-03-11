using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        protected int Id { get; set; } // protected kalıtım ile bağlı olan classlarda da kullanılabilir
        private int Value { get; set; } // private tanımlama sadece tanımlanan classda kullanılır

        public void Savee()
        {

        }

        public void Delete()
        {

        }

    }

    class Student:Customer
    {
        public void Save()
        {
           
        }
    }

    internal class Course  // Olusturulan classların default erişimi internaldır.
    {
        public string Name { get; set; }

        private class NestedClass  //class için private ve protected erişim bildirgiçleri kullanılamaz -- sadece iç içe classlarda kullanılabilir.
        {

        }
    }

    public class Course2 // public kullanarak oluşturulan classlar ise başka projelerde de kullanılabilir
    {

    }

    
}
