using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace lab_8_3
{
    class Program
    {
        static void Serialize(string fileName, List<Car> carList)
        {
            Console.Out.WriteLine("Serializing using binary serialization...");
            
            using (var fileStream = new FileStream($"{fileName}.Data", FileMode.Create))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, carList);
            }
            
            Console.Out.WriteLine("Serialized!");
            Console.Out.WriteLine("Serializing using XML...");

            using (var fileStream = new FileStream($"{fileName}.XML", FileMode.Create))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Car>));
                xmlSerializer.Serialize(fileStream, carList);
            }

            Console.Out.WriteLine("Serialized!");
        }

        static void Deserialize(string fileName)
        {
            Console.Out.WriteLine($"Trying to deserialize {fileName}.Data and {fileName}.XML...");
            
            using (var fileStream = new FileStream($"{fileName}.Data", FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                var data = (List<Car>) binaryFormatter.Deserialize(fileStream);
                
                Console.Out.WriteLine("Deserialized from Binary.");
                
                foreach (var car in data)
                {
                    Console.Out.WriteLine($"\tCar's price: {car.price}");
                }
            }

            using (var fileStream = new FileStream($"{fileName}.XML", FileMode.Open))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Car>));
                var data = (List<Car>) xmlSerializer.Deserialize(fileStream);

                Console.Out.WriteLine("Deserialized from XML.");

                foreach (var car in data)
                {
                    Console.Out.WriteLine($"\tCar quantity: {car.quantity}");
                }
            }
        }

        static void Main(string[] args)
        {
            var fileName = "CarList";
            var carList = new List<Car>
            {
                new Car
                {
                    carId = 0,
                    price = 10999,
                    quantity = 3
                },
                new Car
                {
                    carId = 1,
                    price = 12999,
                    quantity = 2
                },
                new Car
                {
                    carId = 2,
                    price = 59999,
                    quantity = 1
                }
            };

            Serialize(fileName, carList);
            Deserialize(fileName);

            Console.Out.WriteLine("Serialization and Deserialization completed.");
        }
    }
}