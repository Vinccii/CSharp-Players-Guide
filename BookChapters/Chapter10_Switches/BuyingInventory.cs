using System;

namespace CsharpPlayersGuide.Chapter10_Switches;

public static class BuyingInventory
{
	public static void Run()
	{
		Console.WriteLine("Dear Customer, here you can see our Menu!");
		Console.WriteLine("Chose an Item of your choice!");
		Console.WriteLine("Enter a number from 1 to 7 to select an Item!");
		Console.WriteLine("1 – Rope\r\n2 – Torches\r\n3 – Climbing Equipment\r\n4 – Clean Water\r\n5 – Machete\r\n6 – Canoe\r\n7 – Food Supplies");

        int number = Convert.ToInt32(Console.ReadLine());
        int price = 0;

        switch (number)
		{
			case 1:
				price = 10;
				Console.WriteLine($"The Rope costs {price} gold!");
				break;
			case 2:
				price = 15;
				Console.WriteLine($"The Torches costs {price} gold!");
				break;
			case 3:
				price = 25;
				Console.WriteLine($"The Climbing Equipment costs {price} gold!");
				break;
			case 4:
				price = 1;
				Console.WriteLine($"Clean Water costs {price} gold!");
				break;
			case 5:
				price = 20;
				Console.WriteLine($"A Machete costs {price} gold! ");
				break;
			case 6:
				price = 200;
				Console.WriteLine($"A Canoe costs {price} gold!");
				break;
			case 7:
				price = 1;
				Console.WriteLine($"Food Supplies costs {price} gold!");
				break;
			default:
				Console.WriteLine("That Item is currently not avalible");
				break;

		}
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        if (name == "Vincent")
		{
			price /= 2; // Rabatt
		}
		Console.WriteLine($"That will cost {price} gold!");
	}
}
