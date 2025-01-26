int toplamSayi = 0;
int sayilarinToplami = 0;
for (int i = 0; i<100; i++)
{
    if (i % 3 == 0) 
    {
        Console.WriteLine(i);
        toplamSayi++;
        sayilarinToplami += i;
    }
}
Console.WriteLine("3'e Bölünen Toplam Sayı: " + toplamSayi);
Console.WriteLine("3'e Bölünen Sayıların Toplamı: " + sayilarinToplami);
