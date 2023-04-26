using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Theory___Axelrod_Tournament
{
	internal class Player
	{
		public delegate Сhoice Strategy();

		private Strategy strategy;

		public void SetFunction(Strategy newFunction)
		{
			strategy = newFunction;
		}

		public Сhoice ExecuteStrategy()
		{
			return strategy != null ? strategy.Invoke() : default(Сhoice);
		}


		internal int FreedomYears { get; set; }
	}
}
