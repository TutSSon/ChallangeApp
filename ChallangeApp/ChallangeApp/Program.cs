string name = "Ewa";
bool woman = true;
int age = 33;

if (name == "Ewa" && age == 33) 
{
    Console.WriteLine("Ewa, wiek 33 lata");
}

else if (woman == true && age < 30) 
{
    Console.WriteLine("Kobieta poniżej 30");
}

else if (woman == false && age < 18) 
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}



