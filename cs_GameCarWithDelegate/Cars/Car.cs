using System;

namespace cs_GameCarWithDelegate.Cars
{
    public delegate void CarEvent();

    public abstract class Car
    {
        public string Name { get; protected set; }
        public int Speed { get; protected set; }
        public int DownLimit { get; protected set; }
        public Random Rand { get; }
        public float MoveDistanse { get; protected set; }

        public Car() => Rand = new Random();

        public abstract void Move();

        public event CarEvent Finish;
    }
}
