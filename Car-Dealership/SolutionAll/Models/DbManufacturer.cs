using System.Collections.Generic;
using Enums;

namespace Models
{
    public static class DbManufacturer
    {
        public static List<Vehicle> NewVehicles;
        static DbManufacturer()
        {
            NewVehicles = new List<Vehicle>
            {
                new Car("Mercedes-Benz", "E-Class", EngineEnum.Petrol, 3000, 250, TransmissionEnum.Manual, 55000),
                new Car("BMW", "5-Series", EngineEnum.Petrol, 3000, 280, TransmissionEnum.Manual, 50000),
                new Car("Seat", "Leon", EngineEnum.Petrol, 1200, 150, TransmissionEnum.Manual, 12000),
                new Truck("Scania","R-550", EngineEnum.Diesel, 15500, 580, TransmissionEnum.SemiAutomatic, 110000, 2, true),
                new Van("Volkswagen", "Crafter", EngineEnum.Diesel, 2000, 150, TransmissionEnum.Manual, 22000, 1500),
                new Van("Mercedes-Benz ", "Vito", EngineEnum.Diesel, 2500, 190, TransmissionEnum.Manual, 29000, 2500)
            };
        }
    }
}