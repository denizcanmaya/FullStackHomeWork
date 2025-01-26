Console.WriteLine("Birinci Sayıyı Giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Üçüncü Sayıyı Giriniz: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());

if (sayi1 > sayi2 && sayi1 > sayi3)
{
    Console.WriteLine("En Büyük Sayı: " + sayi1);
}
else if (sayi2 > sayi1 && sayi2 > sayi3)
{
    Console.WriteLine("En Büyük Sayı: " + sayi2);
}
else
{
    Console.WriteLine("En Büyük Sayı: " + sayi3);
}