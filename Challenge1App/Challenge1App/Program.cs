var NAME = "Marek";
var SEX = "mezczyzna";
var AGE = 40;

if (SEX == "kobieta" && AGE < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (NAME == "Ewa" && AGE == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (SEX == "mezczyzna" && AGE < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("NIC");
}