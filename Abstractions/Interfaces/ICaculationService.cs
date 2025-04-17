using LogysticSystemService.Moduls;

namespace LogysticSystemService.Abstractions.Interfaces
{
	interface ICaculationService
	{
		float Calculate(CalculationModel calculationModel);
	}
}
