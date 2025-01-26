// See https://aka.ms/new-console-template for more information
// Suyun Sıcaklık Değerine Göre Halleri

Console.WriteLine("Sıcaklık Değeri Giriniz: ");
int sicaklik = int.Parse(Console.ReadLine());
if (sicaklik < 0)
{
    Console.WriteLine("Su donmuş halde.");
}
else if (sicaklik >= 0 && sicaklik < 100)
{
    Console.WriteLine("Su sıvı halde.");
}
else
{
    Console.WriteLine("Su buhar halinde.");
}

