namespace cs_GameCarWithDelegate.Cars
{
    public class Bus : Car
    {
        public Bus() : base()
        {
            Name = "Автобус";
            Speed = 60;
            DownLimit = 30;
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