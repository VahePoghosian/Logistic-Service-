namespace LogysticSystemService.Moduls
{
	public class CarType : Base
	{
		public int Id { get; set; }
		public CarTypeEnum TypeOfCar { get; set; }
	
		public CarType(float coefficient, CarTypeEnum carTypeEnum) : base(coefficient)
		{
			Id = new Random().Next(100, 300);
			TypeOfCar = carTypeEnum;
		}

		public enum CarTypeEnum
		{
			Sedan,
			SUV,
			Hatchback,
			Coupe,
		}
	}
}
