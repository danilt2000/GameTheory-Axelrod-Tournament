using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Theory___Axelrod_Tournament
{
	internal class Player
	{
		public delegate Сhoice Strategy(Сhoice сhoice);

		public Strategy strategy;

		public void SetFunction(Strategy newFunction)
		{
			strategy = newFunction;
		}

		public Сhoice ExecuteStrategy(Сhoice сhoice)
		{
			return strategy != null ? strategy.Invoke(сhoice) : default(Сhoice);
		}

		public string GetCurrentFunction()
		{
			return strategy.ToString();
		}
		internal int FreedomYears { get; set; }
	}
}
