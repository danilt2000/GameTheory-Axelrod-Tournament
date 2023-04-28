using Game_Theory___Axelrod_Tournament;
using Game_Theory___Axelrod_Tournament.Strategies;

internal class Program
{
	internal static AxelrodStrategies axelrodStrategies = new AxelrodStrategies();

	internal static PayrollMatrix payrollMatrix = new PayrollMatrix();
	private static void Main(string[] args)
	{

		Player firstPlayer = new Player();

		Player secondPlayer = new Player();

		AlwaysCooperateFight(firstPlayer, secondPlayer);

	}

	private static void AlwaysCooperateFight(Player firstPlayer, Player secondPlayer)
	{
		Console.WriteLine("The first game 'Always Cooperate' versus 'Always Cooperate'");

		var resultFight = Battle(firstPlayer, secondPlayer, axelrodStrategies.AlwaysCooperate.GetResult, axelrodStrategies.AlwaysCooperate.GetResult);

		axelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		axelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'Always Defect'");

		resultFight = Battle(firstPlayer, secondPlayer, axelrodStrategies.AlwaysCooperate.GetResult, axelrodStrategies.AlwaysDefect.GetResult);

		axelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		axelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'TitForTat'");

		resultFight = Battle(firstPlayer, secondPlayer, axelrodStrategies.AlwaysCooperate.GetResult, axelrodStrategies.TitForTat.GetResult);

		axelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		axelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'PeriodicallyCCD'");

		resultFight = Battle(firstPlayer, secondPlayer, axelrodStrategies.AlwaysCooperate.GetResult, axelrodStrategies.PeriodicallyCCD.GetResult);

		axelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		axelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'PeriodicallyDDC'");

		resultFight = Battle(firstPlayer, secondPlayer, axelrodStrategies.AlwaysCooperate.GetResult, axelrodStrategies.PeriodicallyDDC.GetResult);

		axelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		axelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'PeriodicallyDDC'");

		resultFight = Battle(firstPlayer, secondPlayer, axelrodStrategies.AlwaysCooperate.GetResult, axelrodStrategies.RandomStrategy.GetResult);

		axelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		axelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'DanilStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, axelrodStrategies.AlwaysCooperate.GetResult, axelrodStrategies.DanilStrategy.GetResult);

		axelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		axelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);
	}

	internal static Tuple<int, int> Battle(Player firstPlayer, Player secondPlayer, Player.Strategy firstPlayerStrategy, Player.Strategy secondPlayerStrategy)
	{
		firstPlayer.SetFunction(firstPlayerStrategy);

		secondPlayer.SetFunction(secondPlayerStrategy);

		var resultFight = payrollMatrix.FightOnMatrix(firstPlayer, secondPlayer);

		DisposeFreedomYears(firstPlayer, secondPlayer);

		return resultFight.ToTuple();
	}

	private static void DisposeFreedomYears(Player firstPlayer, Player secondPlayer)
	{
		firstPlayer.FreedomYears = 0;

		secondPlayer.FreedomYears = 0;
	}
}