using Game_Theory___Axelrod_Tournament;
using Game_Theory___Axelrod_Tournament.Strategies;
using System.Reflection.Metadata;
using System.Xml.Serialization;

internal class Program
{
	internal const int NumberOfGames = 200;


	//firstPlayer.SetFunction(axelrodStrategies.AlwaysCooperate.GetResult);

	private static void Main(string[] args)
	{

		PayrollMatrix payrollMatrix = new PayrollMatrix();

		AxelrodStrategies axelrodStrategies = new AxelrodStrategies();

		Player firstPlayer = new Player();

		Player secondPlayer = new Player();





		Console.WriteLine("The first game 'Always Cooperate' versus 'Always Defect'");

		firstPlayer.SetFunction(axelrodStrategies.AlwaysCooperate.GetResult);
		
		secondPlayer.SetFunction(axelrodStrategies.AlwaysDefect.GetResult);

		for (int i = 0; i < NumberOfGames; i++)
		{
			Сhoice firstPlayerChoice = firstPlayer.ExecuteStrategy();
			
			Сhoice secondPlayerChoice = secondPlayer.ExecuteStrategy();

			var resultFight = payrollMatrix.GetResultFight(firstPlayerChoice,secondPlayerChoice);
		}






		//var neco = firstPlayer.ExecuteFunction();







		//axelrodStrategies.TitForTat.GetResult(Сhoice.Betrayal);


		//Сhoice GetResult()
		//{
		//	return Сhoice.Betrayal;
		//}


	}




}