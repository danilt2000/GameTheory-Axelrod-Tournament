using Game_Theory___Axelrod_Tournament.Strategies;

namespace Game_Theory___Axelrod_Tournament
{
	internal class AxelrodStrategies
	{
		internal AlwaysCooperate AlwaysCooperate = new AlwaysCooperate();

		internal AlwaysDefect AlwaysDefect = new AlwaysDefect();

		internal TitForTat TitForTat = new TitForTat();

		internal PeriodicallyCCD PeriodicallyCCD = new PeriodicallyCCD();

		internal PeriodicallyDDC PeriodicallyDDC = new PeriodicallyDDC();
	}
}
