using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace lab_rand
{
    public class Car
    {
        public Int32 carId;
        public decimal price;
        public Int32 quantity;
        public decimal total;

        public Car() {}
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Car();
            using FileStream fs =
                new FileStream(@"C:\Users\kunin\RiderProjects\LNU-lessons\lab rand\Resources\SerializedData.XML",
                    FileMode.Create);
            var xs = new XmlSerializer(typeof(Car));
            xs.Serialize(fs, item);
        }
    }
}
