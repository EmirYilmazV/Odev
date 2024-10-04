using System;

class Program

{
    static void Main()
    {
        Console.WriteLine("*----------------------------*"); 
        Console.WriteLine("Geometrik Ortalama Hesaplayici");  // Extra detay olsun diye bunları ekledim
        Console.WriteLine("*----------------------------*");
 



        Console.WriteLine("Lütfen ilk sayiyi giriniz");   
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen ikinci sayiyi giriniz");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        double gOrtalama = Math.Sqrt(sayi1 * sayi2);          // Gördüğüm bir işlem komudunu geometrik ortalama için kullandım         
        Console.WriteLine("Sayilarin Geometrik ortalamasi:{0}", gOrtalama);
        Console.ReadLine();

    }
 




}
