namespace cs_GameCarWithDelegate.Cars
{
    public class Truck : Car
    {
        public Truck() : base()
        {
            Name = "Грузовик";
            Speed = 60;
            DownLimit = 40;
        }

        public event DelegateCar FinishEvent;

        public override void Move()
        {
            int currentSpeed = Rand.Next(DownLimit, Speed);

            MoveDistanse += (double)currentSpeed / 10;

            if (MoveDistanse >= 100)
            {
                FinishEvent?.Invoke(Name);
            }
        }
    }
}