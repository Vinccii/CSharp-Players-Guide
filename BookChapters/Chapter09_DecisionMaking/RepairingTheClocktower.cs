namespace CsharpPlayersGuide.Chapter09_DecisionMaking;

public static class RepairingTheClocktower
{
    public static void Run()
    {
        Console.Write("Zeit hier eingeben: ");
        if (!int.TryParse(Console.ReadLine(), out int time))
        {
            Console.WriteLine("Ungültige Zahl.");
            return;
        }
        Console.WriteLine(time % 2 == 0 ? "Tick" : "Tock");
    }
}
