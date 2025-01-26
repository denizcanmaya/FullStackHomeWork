while (true)
{
    Console.WriteLine("Sayı Giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == 10)
    {
        Console.WriteLine("Girilen Son Sayı: " + sayi);
        break;
    }
}
Console.ReadLine();