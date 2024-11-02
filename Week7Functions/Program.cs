Console.WriteLine("Are you coming or leaving? (int/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in" )
{
    PrintHello();
}
{
    PrintGoodBye();
}





//PrintHello();
//PrintGoodBye(); 



static void PrintHello() //fuction / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}