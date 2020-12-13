using System;
using System.Runtime.Serialization;

namespace lab_8_3
{
    [Serializable]
    public class Car
    {
        public Int32 carId;
        public decimal price;
        public Int32 quantity;
        public decimal total;

        public Car() {}
    }
}