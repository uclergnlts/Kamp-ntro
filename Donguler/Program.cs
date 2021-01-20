using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin temel Kurs";
            string kurs3 = "Java Başlangıç temel Kurs";
            string kurs4 = "Python Kursu";

            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamaya Başlangıç İçin temel Kurs", "Java Başlangıç temel Kurs", "Python Kursu" };


            for (int i = 0; i <kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)  //Dizi yapılı temaları tek tek dönmeye yarar
            {
                Console.WriteLine(kurs);
            }





            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
