namespace LogysticSystemService.Moduls
{
	public class CarMark
	{
		public int Id { get; set; }
		public string Brand { get; set; }
		public List<CarModels> Models { get; set; }

		public CarMark(string brand, List<CarModels> models)
		{
			Id = new Random().Next(100, 300);
			Brand = brand;
			Models = models;
		}
	}
}
