//int toplam = 0;
//int sayac = 0;
//while (true)
//{
//    Console.WriteLine("Sayı Giriniz: ");
//    int sayi = Convert.ToInt32(Console.ReadLine());
//    toplam += sayi;
//    sayac++;
//    if (toplam >= 100)
//    {
//        Console.WriteLine("Toplam Girilen Değer: " + sayac);
//        Console.WriteLine("Toplam: " + toplam);
//        break;
//    }
//}
//Console.ReadLine();

// For ile

int toplam = 0;
int sayac = 0;
for (; ; ) // Boş bırakarak while true mantığı oluştu.
{
    Console.WriteLine("Sayı Giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;
    sayac++;
    if (toplam >= 100)
    {
        Console.WriteLine("Toplam Girilen Değer: " + sayac);
        Console.WriteLine("Toplam: " + toplam);
        break;
    }
}
Console.ReadLine();