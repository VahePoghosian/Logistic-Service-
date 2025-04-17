
namespace LogysticSystemService.Moduls
{
    public class CalculationModel
    {


        public CarType CarType { get; set; }
        public Direction Direction { get; set; }
        public Container Container { get; set; }
        public Operable Status { get; set; }


        public CalculationModel(CarType carType, Direction carDirection, Container carContainer, Operable operable)
        {
            CarType = carType;
            Direction = carDirection;
            Container = carContainer;
            Status = operable;
        }
    }
}
