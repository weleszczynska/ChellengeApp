// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//var number1 = 50;
//var number2 = 10;
string Name = "Mateusz";
int Age = 17;
bool Male = true;


if (Age < 18)
{
    if (Male == true)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Niepełnoletnia kobieta");
    }
}
else
{
    if (Age < 30)
    {
        if (Male == true)
        {
            Console.WriteLine("Mężczyzna ponieżej 30 lat");
        }
        else
        {
            Console.WriteLine("Kobieta poniżej 30 lat");
        }
    }
    else 
    { 
        Console.WriteLine(Name + ", lat " + Age); 
    }
}

