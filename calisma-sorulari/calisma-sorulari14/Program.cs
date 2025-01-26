

Console.WriteLine("Cinsiyetinizi Giriniz: ");
string cinsiyet = Console.ReadLine().ToLower();
Console.WriteLine("Boyunuzu Giriniz: ");
int boy = int.Parse(Console.ReadLine());

if (cinsiyet == "kadın" && boy >= 150)
{
    int kadinBaslangic = 45;
    float idealKilo = kadinBaslangic;
    if (boy > 150)
    {
        float fazlasi = ((boy - 150) / 2.5f) * 2.2f;
        idealKilo += fazlasi;
    }
    Console.WriteLine("İdeal Kilonuz: " + idealKilo);
}
else if (cinsiyet == "erkek" && boy >= 150)
{
    int erkekBaslangic = 48;
    float idealKiloE = erkekBaslangic;
    if (boy > 150)
    {
        float fazlasi = ((boy - 150) / 2.5f) * 2.7f;
        idealKiloE += fazlasi;
    }
    Console.WriteLine("İdeal Kilonuz: " + idealKiloE);
}
else
{
    Console.WriteLine("Geçersiz boy veya cinsiyet bilgisi girdiniz.");
}

Console.ReadLine();
