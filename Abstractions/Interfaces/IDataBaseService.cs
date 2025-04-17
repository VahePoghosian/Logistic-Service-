using LogysticSystemService.Moduls;
namespace LogysticSystemService.Abstractions.Interfaces
{
	public interface IDataBaseService
	{
		CalculationModel GetCalculationModel(string from, string to, System.ComponentModel.Container container, CarMark carMark, CarModels carModel);
	}
}
