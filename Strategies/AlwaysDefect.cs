using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Theory___Axelrod_Tournament.Strategies
{
	internal class AlwaysDefect
	{
		public IList<int> ResultPlaysFreedomYears = new List<int>();

		internal Сhoice GetResult(Сhoice сhoice)
		{
			return Сhoice.Betrayal;
		}
	}
}
