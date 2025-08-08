namespace CsharpPlayersGuide.Chapter08_Console_2_0;

public static class DefenseOfConsolas
{
    public static void Run()
    {
        Console.Title = "Defense of Consolas";
        Console.Write("Target Row? ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Target Column? ");
        int column = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Deploy the squad in the following areas:");
        Console.WriteLine($"  left  → ({row}, {column - 1})");
        Console.WriteLine($"  up    → ({row - 1}, {column})");
        Console.WriteLine($"  right → ({row}, {column + 1})");
        Console.WriteLine($"  down  → ({row + 1}, {column})");
        Console.Beep(440, 500);
        Console.ResetColor();
    }
}
