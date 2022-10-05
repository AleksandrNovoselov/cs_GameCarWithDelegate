namespace cs_GameCarWithDelegate.Cars
{
    public class SportCar : Car
    {
        public SportCar() : base()
        {
            Name = "Спорткар";
            Speed = 100;
            DownLimit = 20;
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