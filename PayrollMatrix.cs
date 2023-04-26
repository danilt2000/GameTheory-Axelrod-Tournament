using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Theory___Axelrod_Tournament
{
	internal class PayrollMatrix
	{
		internal (int, int) GetResultFight(Сhoice firstChoice, Сhoice secondChoice)
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
	}
}
