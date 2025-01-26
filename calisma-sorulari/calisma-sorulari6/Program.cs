

Console.WriteLine("Bir Sayı Giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for (int i = 0; i <=sayi; i++)
{
    toplam += i;
}
Console.WriteLine("Sayıların Toplamı: " + toplam);
Console.ReadLine();