using System;

namespace prim_class_car_delegate
{
    class Program
    {
        static Car car;
        static void Main(string[] args)
        {
            car.ResiterOnTooF(Reaction);
            car.Start();
            for (int i = 0; i <= 100; i++)
            {
                car.Move();
                Console.WriteLine(i);
            }
                
        }
        private static void Reaction()
        {
            Console.WriteLine("Speed > 50! Car stoped.");
            car.Stop();
        }
    }
}
