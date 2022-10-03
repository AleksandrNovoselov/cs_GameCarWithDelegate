using System;

namespace cs_GameCarWithDelegate.Cars
{
    
    public class PassengerCar : Car
    {

        public PassengerCar():base()
        {
            Name = "Легковой автомобиль";
            Speed = 80;
            DownLimit = 40;
        }
        public new event CarEvent Finish;
        public override void Move()
        {
            int currentSpeed=Rand.Next(DownLimit,Speed);
            MoveDistanse += (float)currentSpeed ;
            if(MoveDistanse >= 100)
            {
                Finish;
            }
        }
        //private void Finish()
        //{
        //    Console.WriteLine("Легковое авто доехало до финиша!!!");
        //}
    }
}