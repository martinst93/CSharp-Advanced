using System.Collections.Generic;
using Enums;

namespace Models
{
    public static class DbVehicles
    {
        public static List<Vehicle> Vehicles;
        static DbVehicles()
        {
            Vehicles = new List<Vehicle>
            {
                new Car("Audi", "A7", EngineEnum.Diesel, 3000, 280, TransmissionEnum.Manual, 70000),
                new Truck("Volvo","FH", EngineEnum.Diesel, 5000, 540, TransmissionEnum.Automatic, 120000, 2, true),
                new Van("Ford", "Transit", EngineEnum.Diesel, 2000, 140, TransmissionEnum.Manual, 35000, 4000),
                new Car("Opel", "Insignia", EngineEnum.Petrol, 2000, 180, TransmissionEnum.Manual, 37000),
                new Car("Volvo", "XC-60", EngineEnum.Petrol, 20000, 220, TransmissionEnum.Manual, 85000)
            };
        }
    }
}