namespace cs_GameCarWithDelegate.Cars
{
    public delegate void DelegateCar(string property);

    public class PassengerCar : Car
    {
        public event DelegateCar FinishEvent;

        public PassengerCar() : base()
        {
            Name = "Легковой автомобиль";
            Speed = 80;
            DownLimit = 40;
        }

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