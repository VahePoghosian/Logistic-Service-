namespace LogysticSystemService.Moduls
{
	public class CarModels
	{
		public CarModels(string name, float coefficient, int year, CarType carType)
		{
			Id = new Random().Next(100, 300);

			Name = name;
			Coefficient = coefficient;
			Year = year;
			CarType = carType;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public int Year { get; set; }
		public float Coefficient { get; set; }
		public CarType CarType { get; set; }
	}
}
