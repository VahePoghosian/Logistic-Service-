namespace LogysticSystemService.Moduls
{
    public class Container
    {

        public int Id { get; set; }
        public float Cofficient { get; set; }
        public IsOpened IsOpenedC { get; set; }

        public Container(float cofficient, IsOpened isOpenedC)
        {
            Id = new Random().Next(100, 300);

            Cofficient = cofficient;
            IsOpenedC = isOpenedC;

        }
        public enum IsOpened
        {
            Yes,
            No
        }

    }
}

