using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Theory___Axelrod_Tournament.Strategies
{
	internal class AlwaysCooperate
	{
		public IList<int> ResultPlaysFreedomYears { get; set; }

		internal Сhoice GetResult()
		{
			return Сhoice.Collaboration;
		}
	}
}
