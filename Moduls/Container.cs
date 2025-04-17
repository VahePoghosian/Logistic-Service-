namespace LogysticSystemService.Moduls
{
	public class Container : Base
	{
		public int Id { get; set; }
		public IsOpened IsOpenedC { get; set; }

		public Container(float coefficient, IsOpened isOpenedC) : base(coefficient)
		{
			Id = new Random().Next(100, 300);
			IsOpenedC = isOpenedC;
		}

		public enum IsOpened
		{
			Yes,
			No
		}
	}
}

