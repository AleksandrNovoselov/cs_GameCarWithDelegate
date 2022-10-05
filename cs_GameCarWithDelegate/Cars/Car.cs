using System;

namespace cs_GameCarWithDelegate.Cars
{
    //public delegate void DelegateCar(string property);

    public abstract class Car
    {
        public string Name { get; protected set; }
        public int Speed { get; protected set; }
        public int DownLimit { get; protected set; }
        public Random Rand { get; }
        public double MoveDistanse { get; protected set; }

        public Car() => Rand = new Random();

        public abstract void Move();

        //public virtual event DelegateCar FinishEvent;
    }
}