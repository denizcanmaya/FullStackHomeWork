// İf-Else

basaDon:
Console.WriteLine("Okuduğunuz okul seviyesi: ");
int bursMiktari = 1000;
string okulSeviyesi = Console.ReadLine();
string ilkOkul = "ilkokul";
string ortaOkul = "ortaokul";
string lise = "lise";
string universite = "üniversite";

if (okulSeviyesi == ilkOkul)
{
    Console.WriteLine("Burs Miktarınız: " + bursMiktari + " TL");
}
else if (okulSeviyesi == ortaOkul)
{
    bursMiktari = bursMiktari + 200;
    Console.WriteLine("Burs Miktarınız: " + bursMiktari + " TL");
}
else if (okulSeviyesi == lise)
{
    bursMiktari = bursMiktari + 500;
    Console.WriteLine("Burs Miktarınız: " + bursMiktari + " TL");
}
else if (okulSeviyesi == universite)
{
    bursMiktari = bursMiktari + 1000;
    Console.WriteLine("Burs Miktarınız: " + bursMiktari + " TL");
}
else
{
    Console.WriteLine("Girilen okul seviyesi yanlış, kontrol edin.");
    goto basaDon;
}

// Switch-Case

//basaDon:
//Console.WriteLine("Okuduğunuz okul seviyesi: ");
//int bursMiktari = 1000;
//string okulSeviyesi = Console.ReadLine();
//string ilkOkul = "ilkokul";
//string ortaOkul = "ortaokul";
//string lise = "lise";
//string universite = "üniversite";

//switch(okulSeviyesi)
//{
//    case "ilkokul":
//        Console.WriteLine("Burs Miktarınız: " + bursMiktari + " TL");
//        break;
//    case "ortaokul":
//        bursMiktari = bursMiktari + 200;
//        Console.WriteLine("Burs Miktarınız: " + bursMiktari + " TL");
//        break;
//    case "lise":
//        bursMiktari = bursMiktari + 500;
//        Console.WriteLine("Burs Miktarınız: " + bursMiktari + " TL");
//        break;
//    case "üniversite":
//        bursMiktari = bursMiktari + 1000;
//        Console.WriteLine("Burs Miktarınız: " + bursMiktari + " TL");
//        break;
//    default:
//        Console.WriteLine("Girilen okul seviyesi yanlış, kontrol edin.");
//        goto basaDon;
//}