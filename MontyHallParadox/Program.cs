using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallParadox
{
	class Program
	{
		static void Main(string[] args)
		{
			var stayWinner = 0;
			var switchWinner = 0;
			var rng = new Random();

			for (var i = 0; i < 1000000;i++)
			{
				var doors = new[] {0, 0, 0};
				var winner = rng.Next(0, 3);
				doors[winner] = 1;
				var choice = rng.Next(0, 3);
				var switchto = 0;
				//Console.WriteLine("Winner {0} Choice {1}", winner, choice);
				if (choice == 0 && winner == 1) switchto = 1;
				if (choice == 0 && winner == 2) switchto = 2;
				if (choice == 0 && winner == 0) switchto = 1;
				if (choice == 1 && winner == 0) switchto = 0;
				if (choice == 1 && winner == 2) switchto = 2;
				if (choice == 1 && winner == 1) switchto = 2;
				if (choice == 2 && winner == 0) switchto = 0;
				if (choice == 2 && winner == 1) switchto = 1;
				if (choice == 2 && winner == 2) switchto = 1;

				if (doors[choice] == 1) stayWinner++;
				if (doors[switchto] == 1) switchWinner++;



			
			}
			Console.WriteLine("Stay Winner {0:N0}", stayWinner);
			Console.WriteLine("Switch Winner {0:N0}", switchWinner);


		}
	}
}
