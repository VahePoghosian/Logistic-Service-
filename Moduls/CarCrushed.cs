namespace LogysticSystemService.Moduls
{
	public class CarCrushed : Base
	{
		public bool IsCrushed { get; set; }
		public Operable Status { get; set; }

		public CarCrushed(bool isCrushed, float coefficient) : base(coefficient)
		{
			IsCrushed = isCrushed;
		}
	}

	public enum Operable
	{
		Yes = 1,
		No = 0,
	}
}
