namespace LogysticSystemService.Moduls
{
	public class Direction
    {
        public int Id { get; set; }
        public string PointA { get; set; }
        public string PointB { get; set; }
        public int Distance { get; set; }
        public float Price { get; set; }

        public Direction(string pointA, string pointB, int distance, int price)
        {
            PointA = pointA;
            PointB = pointB;
            Id = new Random().Next(100, 300);
            Distance = distance;
            Price = price;
        }
    }
}
