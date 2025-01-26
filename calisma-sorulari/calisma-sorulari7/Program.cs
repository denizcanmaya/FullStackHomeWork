Console.WriteLine("Birinci Sayıyı Giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for (int i = sayi1; i <= sayi2; i++)
{
    toplam += i;
}
Console.WriteLine("Sayıların Toplamı: " + toplam);
Console.ReadLine();