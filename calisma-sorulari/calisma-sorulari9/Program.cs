basaDon:
Console.WriteLine("Kare, Üçgen veya Dikdörtgenin Alanını Hesapla: ");
string sekil = Console.ReadLine().ToLower();
switch (sekil)
{
    case "kare":
        Console.WriteLine("Karenin Kenarını Giriniz: ");
        int kareKenar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Karenin Alanı: " + kareKenar * kareKenar);
        Console.WriteLine("Karenin Çevresi: " + (kareKenar * 4));
        break;

    case "üçgen":
        Console.WriteLine("Üçgenin Kenar Ölçülerini Giriniz: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int cevre = a + b + c;
        Console.WriteLine("Üçgenin Çevresi: " + cevre);
        break;

    case "dikdörtgen":
        Console.WriteLine("Dikdörtgenin Kenarlarını Giriniz: ");
        int uzun = Convert.ToInt32(Console.ReadLine());
        int kisa = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Alanı: " + (uzun * kisa));
        Console.WriteLine("Dikdörtgenin Çevresi: " + (2 * (uzun + kisa)));
        break;

    default:
        Console.WriteLine("Geçersiz Şekil");
        goto basaDon;
}
