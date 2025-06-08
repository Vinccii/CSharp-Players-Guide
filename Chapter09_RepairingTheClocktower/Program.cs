Console.WriteLine($"Zeit hier eingeben!");

string input = Console.ReadLine();
int time = Convert.ToInt32(input);

if (time % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}

    

