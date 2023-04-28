using Game_Theory___Axelrod_Tournament.Strategies;

namespace Game_Theory___Axelrod_Tournament
{
	internal class AxelrodStrategies
	{
		//public override IList<int> ResultPlaysFreedomYears ;

  //      public override IList<int> MyProperty { get; set; }

        internal AlwaysCooperate AlwaysCooperate = new AlwaysCooperate();

		internal AlwaysDefect AlwaysDefect = new AlwaysDefect();

		internal TitForTat TitForTat = new TitForTat();

		internal PeriodicallyCCD PeriodicallyCCD = new PeriodicallyCCD();

		internal PeriodicallyDDC PeriodicallyDDC = new PeriodicallyDDC();

		internal RandomStrategy RandomStrategy = new RandomStrategy();

		internal DanilStrategy DanilStrategy = new DanilStrategy();



	}
}
