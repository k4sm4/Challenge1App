var name = "Marek";
var sex = "mezczyzna";
var age = 40;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "mezczyzna" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("NIC");
}