// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada oma vanuse
//kui kasutaja on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young"
//muul juhul 
//konsoolis kuvatakse "Welcome!"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - ture/false

bool isAgeNumber = int.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome!");
    }
    else
    {
        Console.WriteLine("You are too young!");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}


//if (userAge >= 13)
//{
//    Console.WriteLine("Welcome!");
//}
//else 
//{
//    Console.WriteLine("You are too young!");
//}