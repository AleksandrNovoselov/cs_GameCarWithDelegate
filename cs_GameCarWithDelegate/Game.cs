using cs_GameCarWithDelegate.Cars;
using System;

namespace cs_GameCarWithDelegate
{
    public class Game
    {
        public void Start()
        {
            PassengerCar passengerCar = new PassengerCar();

            int count = 1;

            while (true)
            {
                passengerCar.Move();

                Console.WriteLine($"{count++}\t{passengerCar.MoveDistanse}" );

                if (passengerCar.MoveDistanse >= 100)
                {
                    break;
                }
            }
        }

    }
}
