using System;
using System.Data.Common;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
         
            byte b = 5;  // 1 byte
            sbyte c = 4; // 1 byte 

            short d = 5; // 2 byte 
            ushort us = 6; // 2 byte 
            short i16 = 2; // 2 byte 
            int i = 2; // 4 byte
            Int32 i32 = 2; // 4 byte 
            Int64 i64 = 2; // 8 byte 

            uint ui = 2; // 4 byte 
            long l = 2; // 8 byte
            ulong ul = 5; // 8 byte

            float f = 5; // 4 byte 
            double daa = 2; // 8 byte 

            decimal de = 5; // 16 byte

            char ch = '2'; // 2 byte

            string str = "Muzaffer"; // sınırsız

            bool b1 = true;
            bool b2 = false;
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler
            
            string str1 = string.Empty;
            str1 = "Muzaffer Sünbül";
            string ad = "Muzaffer";
            string soyad = "Sünbül";
            string tamIsim = ad+ " "+soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

          // boolen

          bool bool1 = 10<2;
            
          // Değişken Dönüşümleri

          string str20 = "20";
          int int20 = 20;
          string yeniDeger = str20 + int20.ToString() ;
          Console.WriteLine(yeniDeger);

          int int21 = int20 + Convert.ToInt32(str20);
          Console.WriteLine(int21);

          int int22 = int20 + int.Parse(str20);

          // DateTime

          string datetime = DateTime.Now.ToString("dd.MM.yyyy");
          Console.WriteLine(datetime);

          string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
          Console.WriteLine(datetime2);


           string hour = DateTime.Now.ToString("HH:mm");
          Console.WriteLine(hour);


         }
    }
}
