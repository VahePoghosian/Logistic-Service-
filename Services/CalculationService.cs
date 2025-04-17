using LogysticSystemService.Abstractions.Interfaces;
using LogysticSystemService.Moduls;
namespace LogysticSystemService.Services
{
	public class CalculationService : ICaculationService
	{
		private readonly IDataBaseService _databaseService;
	
		public float Calculate(CalculationModel calculationModel)
		{
			return
				calculationModel.CarType.Coefficient *
				calculationModel.Container.Coefficient *
				calculationModel.Container.Coefficient *
				calculationModel.Direction.Price;
		}

		public CalculationService(IDataBaseService databaseService)
		{
			_databaseService = databaseService;
		}
	}
}
