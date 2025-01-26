Console.WriteLine("Yurtiçi veya Yurtdışı Seyehat Bilginizi Giriniz: ");
string seyahat = Console.ReadLine().ToLower();
Console.WriteLine("Alınacak Bilet Adedi: ");
int adet = int.Parse(Console.ReadLine());
int biletFiyati = 1000;

if (seyahat == "yurtdışı")
{
    Console.WriteLine("Lütfen gitmek istediğiniz bölgeyi seçin:");
    Console.WriteLine("a - Avrupa");
    Console.WriteLine("b - Asya");
    Console.WriteLine("c - Amerika");
    string bolge = Console.ReadLine().ToLower();

    switch (bolge)
    {
        case "a":
            Console.WriteLine("Avrupa'ya seyahat seçtiniz.");
            int avrupaFiyati = ((adet * biletFiyati) * 127) / 100;
            Console.WriteLine("Bilet Tutarı: " + avrupaFiyati);
            break;
        case "b":
            Console.WriteLine("Asya'ya seyahat seçtiniz.");
            int asyaFiyati = ((adet * biletFiyati) * 117) / 100;
            Console.WriteLine("Bilet Tutarı: " + asyaFiyati);
            break;
        case "c":
            Console.WriteLine("Amerika'ya seyahat seçtiniz.");
            int AbdFiyati = ((adet * biletFiyati) * 107) / 100;
            Console.WriteLine("Bilet Tutarı: " + AbdFiyati);
            break;
        default:
            Console.WriteLine("Geçersiz seçim.");
            break;
    }
}
else if (seyahat == "yurtiçi")
{
    Console.WriteLine("Seyahat vaktinizi seçiniz.");
    Console.WriteLine("a - Hafta içi");
    Console.WriteLine("b - Hafta sonu");
    string hafta = Console.ReadLine().ToLower();

    switch (hafta) {

        case "a":
        Console.WriteLine("Hafta içi seyahat seçtiniz.");
        int haftaiciFiyati = ((adet * biletFiyati) * 73) / 100;
        Console.WriteLine("Bilet Tutarı: " + haftaiciFiyati);
        break;

        case "b":
        Console.WriteLine("Hafta sonu seyahat seçtiniz.");
        int haftasonuFiyati = ((adet * biletFiyati) * 93) / 100;
        Console.WriteLine("Bilet Tutarı: " + haftasonuFiyati);
        break;

        default:
            Console.WriteLine("Geçersiz seçim.");
            break;
    }
}
else
{
    Console.WriteLine("Geçersiz seyahat bilgisi girdiniz.");
}

Console.ReadLine();

