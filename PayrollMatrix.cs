using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static Game_Theory___Axelrod_Tournament.Player;

namespace Game_Theory___Axelrod_Tournament
{
	internal class PayrollMatrix
	{
		internal const int NumberOfGames = 200;

		internal const Сhoice Null = Сhoice.Null;

		static AxelrodStrategies axelrodStrategies = new AxelrodStrategies();

		private (int, int) GetResultFight(Сhoice firstChoice, Сhoice secondChoice)
		{
			if (firstChoice == Сhoice.Betrayal && secondChoice == Сhoice.Collaboration)
			{
				return (5, 0);
			}

			if (firstChoice == Сhoice.Collaboration && secondChoice == Сhoice.Betrayal)
			{
				return (0, 5);
			}

			if (firstChoice == Сhoice.Betrayal && secondChoice == Сhoice.Betrayal)
			{
				return (1, 1);
			}

			if (firstChoice == Сhoice.Collaboration && secondChoice == Сhoice.Collaboration)
			{
				return (3, 3);
			}

			return (0, 0);
		}

		internal (int, int) FightOnMatrix(Player firstPlayer, Player secondPlayer)
		{
			Сhoice firstPlayerChoice = Сhoice.Null;

			Сhoice secondPlayerChoice = Сhoice.Null;

			for (int step = 0; step < NumberOfGames; step++)
			{
				if (IsStrategyTitForTat(firstPlayer.strategy.Method.DeclaringType.ToString()) || IsStrategyTitForTat(secondPlayer.strategy.Method.DeclaringType.ToString()))
				{

					if (step != 0)
					{
						firstPlayerChoice = firstPlayer.ExecuteStrategy(secondPlayerChoice);
					}
					else
					{
						firstPlayerChoice = firstPlayer.ExecuteStrategy(Сhoice.Collaboration);
					}

					secondPlayerChoice = secondPlayer.ExecuteStrategy(firstPlayerChoice);

					var resultFightTitForTat = GetResultFight(firstPlayerChoice, secondPlayerChoice);

					firstPlayer.FreedomYears += resultFightTitForTat.Item1;

					secondPlayer.FreedomYears += resultFightTitForTat.Item2;

					continue;
				}

				firstPlayerChoice = firstPlayer.ExecuteStrategy(Null);

				secondPlayerChoice = secondPlayer.ExecuteStrategy(Null);

				var resultFight = GetResultFight(firstPlayerChoice, secondPlayerChoice);

				firstPlayer.FreedomYears += resultFight.Item1;

				secondPlayer.FreedomYears += resultFight.Item2;
			}

			return (firstPlayer.FreedomYears, secondPlayer.FreedomYears);
		}

		private bool IsStrategyTitForTat(string input)
		{
			string searchString = "TitForTat";

			if (input.Contains(searchString))
				return true;
			else
				return false;
		}
	}
}
