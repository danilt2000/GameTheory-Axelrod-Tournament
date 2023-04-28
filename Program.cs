using Game_Theory___Axelrod_Tournament;
using Game_Theory___Axelrod_Tournament.Strategies;

internal class Program
{
	internal static AxelrodStrategies AxelrodStrategies = new AxelrodStrategies();

	internal static PayrollMatrix PayrollMatrix = new PayrollMatrix();

	private static void Main(string[] args)
	{

		Player firstPlayer = new Player();

		Player secondPlayer = new Player();

		AlwaysCooperateFight(firstPlayer, secondPlayer);

		Console.WriteLine($"Average number of AlwaysCooperate is {CalculateAverage(AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears)}");

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Clear();

		AlwaysDefectFight(firstPlayer, secondPlayer);

		Console.WriteLine($"Average number of AlwaysDefect is {CalculateAverage(AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears)}");

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Clear();

		TitForTatFight(firstPlayer, secondPlayer);

		Console.WriteLine($"Average number of TitForTat is {CalculateAverage(AxelrodStrategies.TitForTat.ResultPlaysFreedomYears)}");

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Clear();

		PeriodicallyDDCFight(firstPlayer, secondPlayer);

		Console.WriteLine($"Average number of PeriodicallyDDC is {CalculateAverage(AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears)}");

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Clear();

		PeriodicallyCCDFight(firstPlayer, secondPlayer);

		Console.WriteLine($"Average number of PeriodicallyCCD is {CalculateAverage(AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears)}");

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Clear();

		RandomStrategyFight(firstPlayer, secondPlayer);

		Console.WriteLine($"Average number of RandomStrategy is {CalculateAverage(AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears)}");

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Clear();
		
		DanilStrategyFight(firstPlayer, secondPlayer);

		Console.WriteLine($"Average number of PeriodicallyCCD is {CalculateAverage(AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears)}");

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Clear();
	}

	private static void AlwaysCooperateFight(Player firstPlayer, Player secondPlayer)
	{
		Console.WriteLine("The first game 'Always Cooperate' versus 'Always Cooperate'");

		var resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysCooperate.GetResult, AxelrodStrategies.AlwaysCooperate.GetResult);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'Always Defect'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysCooperate.GetResult, AxelrodStrategies.AlwaysDefect.GetResult);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'TitForTat'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysCooperate.GetResult, AxelrodStrategies.TitForTat.GetResult);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'PeriodicallyCCD'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysCooperate.GetResult, AxelrodStrategies.PeriodicallyCCD.GetResult);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'PeriodicallyDDC'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysCooperate.GetResult, AxelrodStrategies.PeriodicallyDDC.GetResult);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'RandomStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysCooperate.GetResult, AxelrodStrategies.RandomStrategy.GetResult);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Cooperate' versus 'DanilStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysCooperate.GetResult, AxelrodStrategies.DanilStrategy.GetResult);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);
	}

	private static void PeriodicallyCCDFight(Player firstPlayer, Player secondPlayer)
	{
		Console.WriteLine("The first game 'PeriodicallyCCD' versus 'PeriodicallyCCD'");

		var resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyCCD.GetResult, AxelrodStrategies.PeriodicallyCCD.GetResult);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyCCD' versus 'Always Defect'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyCCD.GetResult, AxelrodStrategies.AlwaysDefect.GetResult);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyCCD' versus 'TitForTat'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyCCD.GetResult, AxelrodStrategies.TitForTat.GetResult);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyCCD' versus 'Always Cooperate'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyCCD.GetResult, AxelrodStrategies.AlwaysCooperate.GetResult);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyCCD' versus 'PeriodicallyDDC'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyCCD.GetResult, AxelrodStrategies.PeriodicallyDDC.GetResult);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyCCD' versus 'RandomStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyCCD.GetResult, AxelrodStrategies.RandomStrategy.GetResult);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyCCD' versus 'DanilStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyCCD.GetResult, AxelrodStrategies.DanilStrategy.GetResult);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);
	}

	private static void AlwaysDefectFight(Player firstPlayer, Player secondPlayer)
	{
		Console.WriteLine("The first game 'Always Cooperate' versus 'Always Cooperate'");

		var resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysDefect.GetResult, AxelrodStrategies.AlwaysDefect.GetResult);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Defect' versus 'Always Cooperate'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysDefect.GetResult, AxelrodStrategies.AlwaysCooperate.GetResult);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item2);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		Console.WriteLine("The first game 'Always Defect' versus 'TitForTat'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysDefect.GetResult, AxelrodStrategies.TitForTat.GetResult);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Defect' versus 'PeriodicallyCCD'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysDefect.GetResult, AxelrodStrategies.PeriodicallyCCD.GetResult);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Defect' versus 'PeriodicallyDDC'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysDefect.GetResult, AxelrodStrategies.PeriodicallyDDC.GetResult);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Defect' versus 'RandomStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysDefect.GetResult, AxelrodStrategies.RandomStrategy.GetResult);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'Always Defect' versus 'DanilStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.AlwaysDefect.GetResult, AxelrodStrategies.DanilStrategy.GetResult);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);
	}
	private static void TitForTatFight(Player firstPlayer, Player secondPlayer)
	{
		Console.WriteLine("The first game 'TitForTat' versus 'TitForTat'");

		var resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.TitForTat.GetResult, AxelrodStrategies.TitForTat.GetResult);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'TitForTat' versus 'Always Defect'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.TitForTat.GetResult, AxelrodStrategies.AlwaysDefect.GetResult);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		Console.WriteLine("The first game 'TitForTat' versus 'Always Defect'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.TitForTat.GetResult, AxelrodStrategies.AlwaysDefect.GetResult);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		Console.WriteLine("The first game 'TitForTat' versus 'PeriodicallyCCD'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.TitForTat.GetResult, AxelrodStrategies.PeriodicallyCCD.GetResult);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'TitForTat' versus 'PeriodicallyDDC'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.TitForTat.GetResult, AxelrodStrategies.PeriodicallyDDC.GetResult);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'TitForTat' versus 'RandomStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.TitForTat.GetResult, AxelrodStrategies.RandomStrategy.GetResult);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'TitForTat' versus 'DanilStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.TitForTat.GetResult, AxelrodStrategies.DanilStrategy.GetResult);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);
	}
	private static void PeriodicallyDDCFight(Player firstPlayer, Player secondPlayer)
	{
		Console.WriteLine("The first game 'PeriodicallyDDC' versus 'PeriodicallyDDC'");

		var resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyDDC.GetResult, AxelrodStrategies.PeriodicallyDDC.GetResult);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyDDC' versus 'Always Cooperate'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyDDC.GetResult, AxelrodStrategies.AlwaysCooperate.GetResult);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		Console.WriteLine("The first game 'PeriodicallyDDC' versus 'TitForTat'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyDDC.GetResult, AxelrodStrategies.TitForTat.GetResult);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyDDC' versus 'PeriodicallyCCD'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyDDC.GetResult, AxelrodStrategies.PeriodicallyCCD.GetResult);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyDDC' versus 'Always Defect'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyDDC.GetResult, AxelrodStrategies.AlwaysDefect.GetResult);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		Console.WriteLine("The first game 'PeriodicallyDDC' versus 'RandomStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyDDC.GetResult, AxelrodStrategies.RandomStrategy.GetResult);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'PeriodicallyDDC' versus 'DanilStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.PeriodicallyDDC.GetResult, AxelrodStrategies.DanilStrategy.GetResult);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);
	}

	private static void RandomStrategyFight(Player firstPlayer, Player secondPlayer)
	{
		Console.WriteLine("The first game 'RandomStrategy' versus 'RandomStrategy'");

		var resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.RandomStrategy.GetResult, AxelrodStrategies.RandomStrategy.GetResult);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'RandomStrategy' versus 'Always Cooperate'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.RandomStrategy.GetResult, AxelrodStrategies.AlwaysCooperate.GetResult);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		Console.WriteLine("The first game 'RandomStrategy' versus 'TitForTat'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.RandomStrategy.GetResult, AxelrodStrategies.TitForTat.GetResult);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'RandomStrategy' versus 'PeriodicallyCCD'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.RandomStrategy.GetResult, AxelrodStrategies.PeriodicallyCCD.GetResult);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'RandomStrategy' versus 'PeriodicallyDDC'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.RandomStrategy.GetResult, AxelrodStrategies.PeriodicallyDDC.GetResult);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'RandomStrategy' versus 'Always Defect'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.RandomStrategy.GetResult, AxelrodStrategies.AlwaysDefect.GetResult);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		AxelrodStrategies.AlwaysDefect.ResultPlaysFreedomYears.Add(resultFight.Item1);

		Console.WriteLine("The first game 'RandomStrategy' versus 'DanilStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.RandomStrategy.GetResult, AxelrodStrategies.DanilStrategy.GetResult);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);
	}
	private static void DanilStrategyFight(Player firstPlayer, Player secondPlayer)
	{
		Console.WriteLine("The first game 'DanilStrategy' versus 'DanilStrategy'");

		var resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.DanilStrategy.GetResult, AxelrodStrategies.DanilStrategy.GetResult);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'DanilStrategy' versus 'Always Cooperate'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.DanilStrategy.GetResult, AxelrodStrategies.AlwaysCooperate.GetResult);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);

		Console.WriteLine("The first game 'DanilStrategy' versus 'TitForTat'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.DanilStrategy.GetResult, AxelrodStrategies.TitForTat.GetResult);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.TitForTat.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'DanilStrategy' versus 'PeriodicallyCCD'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.DanilStrategy.GetResult, AxelrodStrategies.PeriodicallyCCD.GetResult);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyCCD.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'DanilStrategy' versus 'PeriodicallyDDC'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.DanilStrategy.GetResult, AxelrodStrategies.PeriodicallyDDC.GetResult);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.PeriodicallyDDC.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'DanilStrategy' versus 'RandomStrategy'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.DanilStrategy.GetResult, AxelrodStrategies.RandomStrategy.GetResult);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item1);

		AxelrodStrategies.RandomStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		Console.WriteLine("The first game 'DanilStrategy' versus 'Always Cooperate'");

		resultFight = Battle(firstPlayer, secondPlayer, AxelrodStrategies.DanilStrategy.GetResult, AxelrodStrategies.AlwaysCooperate.GetResult);

		AxelrodStrategies.DanilStrategy.ResultPlaysFreedomYears.Add(resultFight.Item2);

		AxelrodStrategies.AlwaysCooperate.ResultPlaysFreedomYears.Add(resultFight.Item1);
	}


	internal static Tuple<int, int> Battle(Player firstPlayer, Player secondPlayer, Player.Strategy firstPlayerStrategy, Player.Strategy secondPlayerStrategy)
	{
		firstPlayer.SetFunction(firstPlayerStrategy);

		secondPlayer.SetFunction(secondPlayerStrategy);

		var resultFight = PayrollMatrix.FightOnMatrix(firstPlayer, secondPlayer);

		DisposeFreedomYears(firstPlayer, secondPlayer);

		Console.WriteLine($"First result {resultFight.Item1} Second result {resultFight.Item2}");

		return resultFight.ToTuple();
	}

	private static void DisposeFreedomYears(Player firstPlayer, Player secondPlayer)
	{
		firstPlayer.FreedomYears = 0;

		secondPlayer.FreedomYears = 0;
	}

	private static int CalculateAverage(IList<int> numbers)
	{
		if (numbers.Count == 0)
		{
			throw new ArgumentException("The list must contain at least one number.");
		}

		int sum = 0;
		foreach (int number in numbers)
		{
			sum += number;
		}

		int average = sum / numbers.Count;
		return average;
	}
}