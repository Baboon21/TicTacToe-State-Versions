using System;
					
public class Program
{
	static void Main()
{
    bool running = true;
    while (running)
    {
        //Console.Clear(); the reason why i'm leaving in a comment format is because instead of clearing the console it outputs: [H[2J[3J. Delete comment if you want to use
        Console.WriteLine("=== Game Suite Menu ===");
        Console.WriteLine("1. Rock Paper Scissors");
        Console.WriteLine("2. Naughts and Crosses");
        Console.WriteLine("3. Exit");
        Console.Write("Choose (1-3): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                //startRPS();  //these are currently a place holder for my games i will make in the future
                break;
            case "2":
                //startTicTacToe();  
                break;
            case "3":
                running = false;
                Console.WriteLine("Thanks for playing!");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
}
