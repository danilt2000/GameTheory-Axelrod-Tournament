﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Theory___Axelrod_Tournament.Strategies
{
	internal class PeriodicallyDDC
	{
		public IList<int> ResultPlaysFreedomYears = new List<int>();

		public IList<Сhoice>? ChoicesHistory = new List<Сhoice>();

		internal Сhoice GetResult(Сhoice сhoice)
		{
			if (ChoicesHistory.Count == 0)
			{
				ChoicesHistory.Add(Сhoice.Null);

				return Сhoice.Betrayal;
			}
			if (ChoicesHistory.Count == 1)
			{
				ChoicesHistory.Add(Сhoice.Null);

				return Сhoice.Betrayal;
			}
			if (ChoicesHistory.Count == 2)
			{
				ChoicesHistory.Clear();

				return Сhoice.Collaboration;
			}

			return Сhoice.Null;
		}
	}
}
