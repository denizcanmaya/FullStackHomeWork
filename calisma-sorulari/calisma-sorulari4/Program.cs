// Elekttrik Tüketim Faturası

Console.WriteLine("Tüketilen kWh Miktarını Giriniz: ");
float tuketim = float.Parse(Console.ReadLine());

if (tuketim < 150)
{
    Console.WriteLine("Elektrik Faturanız: " + (tuketim * 0.1) + " TL");
}
else if (tuketim >= 150 && tuketim <= 300)
{
    Console.WriteLine("Elektrik Faturanız: " + (tuketim * 0.2) + " TL");
}
else if (tuketim > 300)
{
    Console.WriteLine("Elektrik Faturanız: " + (tuketim * 0.4) + " TL");
}
Console.ReadLine();