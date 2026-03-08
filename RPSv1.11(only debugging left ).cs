using System;
					
public class Program
{
	public static void Main()
	{
		startGame();
		
	}	
	
	public static void startGame()//for this function it should be as simple as just calling all the bunch of functions and turning them into variables
	{
		
		Console.WriteLine("=== Rock, Paper, Scissors");
		while(true)
		{
			
			int userChoice = userMove();

			int compChoice = computerMove();//gets result(input)from functions

			int desision = decisionMaking(userChoice, compChoice);


			switch(desision)
			{
				case 0:
					Console.WriteLine("PLAYER HAS LOST TO COMP. 1 for exit 2 to play again");
					break;
				case 1:
					Console.WriteLine("PLAYER HAS WON. 		1 for exit, 2 to play again");
					break;
				case 2:
					Console.WriteLine("GAME IS TIED. 		1 for exit, 2 to play again");
					break;
			}
			string read  = Console.ReadLine();
			if (int.TryParse(read, out int INPUT))
				{
					if(INPUT == 1)
					{
						Console.WriteLine("Exit selected");
						break;
					}
				}
			
		}
		//here is should display the choice
	}
	
	
	 public static int decisionMaking(int userMove, int computerMove) 
	 {
		 //s=1 , p=2 , r=3
		 
		 //here is the 2D array in which the winning/losing/tie consditions are stored
		 //User1: s=1,p=2,r=3,r=3
		 //User2: p=2,r=3,p=2,s=1
		 //these combinations make 4 points in a 2D array
		 int [,] conditionsWTL = new int [4,4]
		 {

			 {2,0,0,0},
			 {0,2,1,0},
			 {0,0,2,1},
			 {0,1,1,2}
		 };
		 
		 int decision = conditionsWTL[userMove,computerMove];
		 
		 return decision;
		 
	 }
	
	
//ASCII code because I thought it would be a fun but simple surprise
		public static string displayRock()
		{
			//the variable adding is similar to adding an integer not sure how this will display though. could have named it anything but i chose the most random one.
			string figure = "";
			figure +="'Rock'";
			figure +="    _______\n";
			figure +="---'   ____)\n";
			figure +="      (_____)\n";
			figure +="      (_____)\n";
			figure +="      (____)\n";
			figure +="---.__(___)\n";	
			Console.WriteLine(figure);
			return figure;
		}
	
	public static string displayPaper()
	{
		string figure = "";
		figure += 
		figure += "     _______\n";
		figure += "---'    ________\n";
		figure += "           ______)\n";
		figure += "          _______)\n";
		figure += "         _______)\n";
		figure += "---.__________)\n";
		Console.WriteLine(figure);
		return figure;
	}
	public static string displayScissors()
	{
	string figure = "";
		figure += "    ______\n";
		figure += "---'   ___)____\n";
		figure += "          ______)\n";
		figure += "       __________)\n";
		figure += "      (____)\n";
		figure += "---.__(___)\n";
		Console.WriteLine(figure);
		return figure;
	}
	
	public static int computerMove()
		{
		Console.WriteLine("The computer chose:");
		Random random = new Random();

            // Generate a random integer between 0 (inclusive) and 3 (exclusive)
        int randomNumber = random.Next(1, 4);
			
		switch(randomNumber)
		{
			case 1:displayRock(); return randomNumber;
			case 2:displayScissors();return randomNumber;
			default:displayPaper();	return randomNumber;
		}
		
		
	}
	public static int userMove()
	{
		Console.Write("Enter 1 (Rock), 2 (Paper), 3 (Scissors): "); //asks user for input
		while(true)
			
		{
		string input = Console.ReadLine(); //input
		// here the input gets parsed and the value 1-3 gets selected
		if (int.TryParse(input, out int INPUT) && INPUT >= 1 && INPUT <= 3) 
			{
			Console.WriteLine("PLAYER chose:");
  			  switch(INPUT)
				{
					  //the value(input) that is in the cases is returned
					case 1:  displayRock(); return INPUT;
					case 2:  displayScissors(); return INPUT;
					case 3:  displayPaper(); return INPUT;
				}
			}
			else {
			Console.WriteLine("That's invalid. 		Please enter 1, 2, or 3!"); // after seeing a few different patterns in code i've seen online i've learned that sometimes the else is not needed(i would rather use that but i want to show what i have learned).
		}
			Console.WriteLine("PLAYER chose" + input);
	}
}
}
