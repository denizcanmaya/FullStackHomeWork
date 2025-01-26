
int[] sayilar = new int[7];
int toplam = 0;
Random rnd = new Random();

for (int i = 0; i < 7; i++)
{
    int sayi = rnd.Next(1, 1000);
    sayilar[i] = sayi;
    if (sayi % 10 == 0)
    {
        Console.WriteLine("Birler Basamağı 0: " + sayi);
        toplam += sayi;
    }
}

Console.WriteLine("Dizi: " + string.Join(", ", sayilar));
Console.WriteLine("Birler basamağı 0 olan sayıların toplamı: " + toplam);

