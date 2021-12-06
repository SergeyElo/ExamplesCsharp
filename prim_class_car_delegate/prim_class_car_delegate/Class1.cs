using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim_class_car_delegate
{
    class Car
    {
        int speed = 0;
        public delegate void TooF();
        private TooF toof;
        public void Start()
        {
            speed = 5;
        }
        public void Move()
        {
            speed += 15;
            if (speed > 50)
                toof();
        }
        public void Stop()
        {
            speed = 0;
        }
        public void ResiterOnTooF(TooF toof)
        {
            this.toof = toof;
        }
    }
}
