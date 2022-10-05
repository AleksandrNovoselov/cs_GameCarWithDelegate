using cs_GameCarWithDelegate.Cars;
using System;

namespace cs_GameCarWithDelegate
{
    public class Game
    {
        public void Start()
        {
            var passengerCar = new PassengerCar();
            var sportCar = new SportCar();
            var truck = new Truck();
            var bus = new Bus();

            passengerCar.FinishEvent += Finish;
            sportCar.FinishEvent += Finish;
            truck.FinishEvent += Finish;
            bus.FinishEvent += Finish;

            int count = 1;

            Console.WriteLine($"   {passengerCar.Name}\t{sportCar.Name}\t{truck.Name}\t{bus.Name}");

            while (true)
            {
                passengerCar.Move();
                sportCar.Move();
                truck.Move();
                bus.Move();

                Console.WriteLine($"{count++}\t{passengerCar.MoveDistanse}\t\t{sportCar.MoveDistanse}" +
                    $"\t\t{truck.MoveDistanse}\t\t{bus.MoveDistanse}");

                if (passengerCar.MoveDistanse >= 100 || sportCar.MoveDistanse >= 100 || truck.MoveDistanse >= 100 || bus.MoveDistanse >= 100)
                {
                    break;
                }
            }
        }

        private void Finish(string name)
        {
            Console.WriteLine($"{name} доехал до финиша!!!");
        }
    }
}