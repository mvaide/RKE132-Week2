//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutajalt sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr [kasutaja perekonnanimi]" / "Welcome, Ms [kasutaja perekonnanimi]"



Console.WriteLine("Please, select your gender (m/f)");

char userGender = char.Parse(Console.ReadLine()); //Loeb konsoolist maha andmeid string (sõne) format

Console.WriteLine($"Please, enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}


