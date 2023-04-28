using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Theory___Axelrod_Tournament.Strategies
{
	internal class TitForTat
	{
		public IList<int> ResultPlaysFreedomYears = new List<int>();

		public IList<Сhoice>? ChoicesHistory = new List<Сhoice>();

		internal Сhoice GetResult(Сhoice enemyChoise)
		{
			if (ChoicesHistory.Count == 0)
			{
				ChoicesHistory.Add(enemyChoise);

				return Сhoice.Collaboration;
			}

			Сhoice returnChoise = ChoicesHistory.Last();

			ChoicesHistory.Add(enemyChoise);

			return returnChoise;
		}
	}
}
