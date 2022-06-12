using System;

int wins = 0;
int losses = 0;
int draws = 0;

string[] rock =
{
	"      _____        ",
	"-----' ____)       ",
	"      (_____)      ",
	"      (_____)      ",
	"      (____)       ",
	"---.__(___)        ",
};
string[] paper =
{
	"    ________       ",
	"---'    ____)____  ",
	"           ______) ",
	"          _______) ",
	"         _______)  ",
	"---.__________)    ",
};
string[] scissors =
{
	"    _______        ",
	"---'   ____)____   ",
	"          ______)  ",
	"       __________) ",
	"      (____)       ",
	"---.__(___)        ",
};

int rpsGame;

Random rps = new();

string choice;
Console.WriteLine("Rock, Paper, Scissors\n");
Game();

void Game()
{
	while (true)
	{
		rpsGame = rps.Next(1, 4);

		Console.Write("Choose [r]ock, [p]aper, [s]cissors, or [e]xit: ");
		choice = Console.ReadLine();

		if (choice.ToUpper() == "r".ToUpper() || choice.ToUpper() == "rock".ToUpper())
		{
			if (rpsGame == 1)
			{
				PrintMoves(rock, rock);
				Console.WriteLine("\nThe computer chose Rock.");
				Console.WriteLine("The game was a draw.");
				draws++;
			}
			else if (rpsGame == 2)
			{
				PrintMoves(rock, paper);
				Console.WriteLine("\nThe computer chose Paper.");
				Console.WriteLine("You lose.");
				losses++;
			}
			else if (rpsGame == 3)
			{
				PrintMoves(rock, scissors);
				Console.WriteLine("\nYou win.");
				wins++;
			}
		}
		else if (choice.ToUpper() == "p".ToUpper() || choice.ToUpper() == "paper".ToUpper())
		{
			if (rpsGame == 1)
			{
				PrintMoves(paper, rock);
				Console.WriteLine("\nThe computer chose Rock.");
				Console.WriteLine("You win.");
				wins++;
			}
			else if (rpsGame == 2)
			{
				PrintMoves(paper, paper);
				Console.WriteLine("\nThe computer chose Paper.");
				Console.WriteLine("The game was a draw.");
				draws++;
			}
			else if (rpsGame == 3)
			{
				PrintMoves(paper, scissors);
				Console.WriteLine("\nThe computer chose Scissors.");
				Console.WriteLine("You lose.");
				losses++;
			}
		}
		else if (choice.ToUpper() == "s".ToUpper() || choice.ToUpper() == "scissors".ToUpper())
		{
			if (rpsGame == 1)
			{
				PrintMoves(scissors, rock);
				Console.WriteLine("\nThe computer chose Rock.");
				Console.WriteLine("You lose.");
				losses++;
			}
			else if (rpsGame == 2)
			{
				PrintMoves(scissors, paper);
				Console.WriteLine("\nThe computer chose Paper.");
				Console.WriteLine("You win.");
				wins++;
			}
			else if (rpsGame == 3)
			{
				PrintMoves(scissors, scissors);
				Console.WriteLine("\nThe computer chose Scissors.");
				Console.WriteLine("The game was a draw.");
				draws++;
			}

		}
		else if (choice.ToUpper() == "e".ToUpper() || choice.ToUpper() == "exit".ToUpper())
		{
			Console.Clear();
			Console.WriteLine("Rock, Paper, Scissors was closed.");
			break;
		}
		else
		{
			Console.WriteLine("Invalid Input. Try Again...");
			continue;
		}


		Console.WriteLine("Score: " + wins + " wins, " + losses + " losses, " + draws + " draws");

		Console.WriteLine("Press Enter To Continue...");
		Console.ReadLine();

		Console.Clear();
		Console.WriteLine("Rock, Paper, Scissors\n");
	}
}

void PrintMoves(string[] left, string[] right)
{
	for (int i = 0; i < left.Length; i++)
	{
		string right_i = right[i].Replace(")", "$").Replace("(", ")").Replace("$", "(");
		char[] array = right_i.ToCharArray();
		Array.Reverse(array);
		Console.WriteLine($"{left[i]}{new string(array)}");
	}
}