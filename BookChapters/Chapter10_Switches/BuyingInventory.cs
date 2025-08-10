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

        switch (number)
		{
			case 1:
				Console.WriteLine("The Rope costs 10 gold!");
				break;
			case 2:
				Console.WriteLine("The Torches costs 15 gold!");
				break;
			case 3:
				Console.WriteLine("The Climbing Equipment costs 25 gold!");
				break;
			case 4:
				Console.WriteLine("Clean Water costs 1 gold!");
				break;
			case 5:
				Console.WriteLine("A Machete costs 20 gold! ");
				break;
			case 6:
				Console.WriteLine("A Canoe costs 200 gold!");
				break;
			case 7:
				Console.WriteLine("Food Supplies costs 1 gold!");
				break;
			default:
				Console.WriteLine("That Item is currently not avalible");
				break;

		}
	}
}
