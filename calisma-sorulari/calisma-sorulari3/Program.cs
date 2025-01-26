float toplamKomisyon = 0;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Alış Fiyatı Giriniz: ");
    string alisFiyati = Console.ReadLine();
    float komisyon = 0;

    if (float.TryParse(alisFiyati, out float alisFiyatiF))
    {
        if (alisFiyatiF <= 200)
        {
            komisyon = (alisFiyatiF * 1.03f) - alisFiyatiF;
        }
        else if (alisFiyatiF > 200)
        {
            komisyon = (alisFiyatiF * 1.02f) - alisFiyatiF;
        }

        Console.WriteLine("Alınacak Komisyon: " + komisyon);
        toplamKomisyon += komisyon;
    }
    else
    {
        Console.WriteLine("Geçersiz fiyat girdiniz, lütfen tekrar deneyin.");
    }
}

Console.WriteLine("Toplam Alınan Komisyon: " + toplamKomisyon);

