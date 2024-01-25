var imie = "Marek";
var plec = "mezczyzna";
var wiek = 40;

if (plec == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (imie == "Ewa" && wiek == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (plec == "mezczyzna" && wiek < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("NIC");
}