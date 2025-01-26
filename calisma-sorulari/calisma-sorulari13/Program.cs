
        List<int> uretilenSayi = new List<int>();
        int toplam = 0;
        Random rnd = new Random();

        while (true)
        {
            int sayi = rnd.Next(1, 100);
            if (sayi == 50)
            {
                Console.WriteLine("Sayı 50 olduğu için döngüden çıkıldı.");
                break;
            }
            uretilenSayi.Add(sayi);
            toplam += sayi;
        }

        string sayilar = string.Join(", ", uretilenSayi);
Console.WriteLine("Toplam: " + toplam);
Console.WriteLine("Üretilen Sayılar: " + sayilar);
        

