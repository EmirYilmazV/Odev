using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Adinizi Ve Soyadinizi Giriniz");
        Console.WriteLine("↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓"); // İlk önce gereken şeyleri yazıcağımız yerleri ayarladım
        string adsoyad = Console.ReadLine();

        Console.WriteLine("Öğrenci Numaranizi Giriniz");
        Console.WriteLine("↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓");
        string ogrencino = Console.ReadLine();

        Console.WriteLine("Telefon Numaranizi Giriniz");
        Console.WriteLine("↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓");
        string numara = Console.ReadLine();


        Console.WriteLine("*----------------------------*");    // Hepsi bittikten sonra ise panel tarzında yazılan her bilginin gözüktüğü yeri yaptım
        Console.WriteLine("Adi Soyadi: " + adsoyad);               
        Console.WriteLine("Öğrenci Numarasi: " + ogrencino);
        Console.WriteLine("Numarasi: " + numara);
        Console.WriteLine("*----------------------------*");



    }








}
