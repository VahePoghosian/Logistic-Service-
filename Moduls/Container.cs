namespace LogysticSystemService.Moduls
{
    public class Container
    {

        public int Id { get; set; }
        public float Cofficient { get; set; }
        public IsOpened IsOpenedC { get; set; }

        public Container(int id, float cofficient, IsOpened isOpenedC)
        {
            Id = id;
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

