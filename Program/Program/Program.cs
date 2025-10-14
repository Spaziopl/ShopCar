// See https://aka.ms/new-console-template for more information

string name = "Andrzej";
int age = 23;
double high = 1.85;
bool isPrograming = true;

Console.WriteLine($"Cześć! Mam na imię {name}, mam {age}, i mój wzrost to {high}m.");
Console.WriteLine($"Czy lubię programować? Odpowiedż to: {isPrograming}");


if (age >= 18)
{
    Console.WriteLine("Jesteś pełnoletni");
}
else Console.WriteLine("Jeszcze nie jesteś pelnoletni");

for(int i = 0; i <= 5; i++)
{
    Console.WriteLine($"Licznik: {i}");
}
