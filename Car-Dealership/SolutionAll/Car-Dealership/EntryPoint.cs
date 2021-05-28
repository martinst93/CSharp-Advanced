using System;
using System.Collections.Generic;
using Models.Vehicles;
using Models;
using Models.Enums;
using System.Linq;

namespace Car_Dealership
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            #region InStock
            List<Car> CarListInStock = new List<Car>();
            CarListInStock.Add(new Car("Gasoline", "BMW", "M3", 30000, "Car"));
            CarListInStock.Add(new Car("Diesel", "Audi", "A3", 35000, "Car"));
            CarListInStock.Add(new Car("Electricity", "Tesla", "Modes-S", 45000, "Car"));

            List<Van> VanListInStock = new List<Van>();
            VanListInStock.Add(new Van("Small", "Citroen", "Relay", 25000, "Van"));
            VanListInStock.Add(new Van("Medium", "Peugeot", "Boxer", 30000, "Van"));
            VanListInStock.Add(new Van("Large", "Fiat", "Ducato", 35000, "Van"));

            List<Truck> TruckListInStock = new List<Truck>();
            TruckListInStock.Add(new Truck("Volvo", "FH", 35000, "Truck", "No Trailer"));
            TruckListInStock.Add(new Truck("Scania", "S 730", 35000, "Truck", "One Trailer"));
            TruckListInStock.Add(new Truck("Man", "TGX", 50000, "Truck", "Two Trailers"));
            #endregion

            #region AccountLists & VehicleLists
            Catalog CatalogList = new Catalog(CarListInStock, VanListInStock, TruckListInStock, true);

            List<Order> OrdersList = new List<Order>();
            OrdersList.Add(new Order("Citroen", "C4", 20000, "Car"));
            OrdersList.Add(new Order("Fiat", "Doblo", 25000, "Van"));
            OrdersList.Add(new Order("Mercedes-Benz", "Actros", 75000, "Truck"));

            List<Customer> CustomerList = new List<Customer>();
            CustomerList.Add(new Customer(1, "Tod", "Smith", "TS", "111", Enum_Role.Customer));
            CustomerList.Add(new Customer(2, "Will", "Johnson", "WJ", "222", Enum_Role.Customer));
            CustomerList.Add(new Customer(3, "Bill", "Brown", "BB", "333", Enum_Role.Customer));

            List<SalesEmployee> SalesEployeeList = new List<SalesEmployee>();
            SalesEployeeList.Add(new SalesEmployee(4, "John", "Jones", "JJ", "444", Enum_Role.SalesEmployee));
            SalesEployeeList.Add(new SalesEmployee(5, "Sarah", "Johnson", "SJ", "555", Enum_Role.SalesEmployee));
            SalesEployeeList.Add(new SalesEmployee(6, "Nancy", "Brown", "NB", "666", Enum_Role.SalesEmployee));

            List<ProcurementEmployee> ProcurementEmployeesList = new List<ProcurementEmployee>();
            ProcurementEmployeesList.Add(new ProcurementEmployee(7, "Tom", "Moore", "TM", "777", Enum_Role.ProcurementEmployee, OrdersList, CatalogList));
            ProcurementEmployeesList.Add(new ProcurementEmployee(8, "Bobby", "Lee", "BL", "888", Enum_Role.ProcurementEmployee, OrdersList, CatalogList));
            ProcurementEmployeesList.Add(new ProcurementEmployee(9, "Susan", "Lewis", "SL", "999", Enum_Role.ProcurementEmployee, OrdersList, CatalogList));

            List<PendingOrder> PendingOrderList = new List<PendingOrder>();
            AccountsCollection accountsCollection = new AccountsCollection(CustomerList, SalesEployeeList, ProcurementEmployeesList);
            #endregion

            while (true)
            {

                Console.WriteLine("Please enter user name");
                string userNameInput = Console.ReadLine();

                Console.WriteLine("Please enter password");
                string passwordInput = Console.ReadLine();

                Customer LoginUser = CustomerList.FirstOrDefault(x => x.Validate(userNameInput, passwordInput) != null);
                SalesEmployee LoginSalesEmployee = SalesEployeeList.FirstOrDefault(x => x.Validate(userNameInput, passwordInput) != null);
                //AccountsCollection.Validate(accountsCollection, userNameInput, passwordInput);

                if (LoginUser.Role == Enum_Role.SalesEmployee)
                {
                    Catalog.SeeTheCatalog(CatalogList);
                    Console.WriteLine("To buy a car enter 1.");
                    Console.WriteLine("To buy a van enter 2.");
                    Console.WriteLine("To buy a truck enter 3.");

                    int numberInput = int.Parse(Console.ReadLine());

                    switch (numberInput)
                    {
                        #region CarInputs
                        case 1:

                            Console.WriteLine("You can choose a car from the ones in the catalog, or we can place an order.");
                            Console.WriteLine("Please choose the car manufacturer.");
                            string carManufacturerInput = Console.ReadLine();
                            Console.WriteLine("Please choose the model of the car.");
                            string carModelInput = Console.ReadLine();
                            Console.WriteLine("Please choose the type of fuel for the car.");
                            string carFuelInput = Console.ReadLine();
                            Console.WriteLine("Please type the price that you think the car is.");
                            decimal carPriceInput = decimal.Parse(Console.ReadLine());

                            foreach (var car in CarListInStock)
                            {
                                if (car.Manufacturer != carManufacturerInput && car.Model != carModelInput && car.TypeOfFuel != carFuelInput && car.Price != carPriceInput)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(new string('-', 90));
                                    Console.WriteLine("We need to place an order the car is not in the inventory!!!");
                                    Console.WriteLine(new string('-', 90));
                                    Console.ResetColor();

                                    Console.WriteLine("Please choose the car manufacturer.");
                                    string carManufacturerInput1 = Console.ReadLine();
                                    Console.WriteLine("Please choose the model of the car.");
                                    string carModelInput1 = Console.ReadLine();
                                    Console.WriteLine("Please choose the type of fuel for the car.");
                                    string carFuelInput1 = Console.ReadLine();

                                    if (carFuelInput1 == "Gasoline")
                                    {
                                        Console.WriteLine("Please type the price that you think the car is.");
                                        decimal carPriceInput1 = decimal.Parse(Console.ReadLine());

                                        PendingOrderList.Add(new PendingOrder(carManufacturerInput1, carModelInput1, carPriceInput1, carFuelInput1));

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(new string('-', 90));
                                        Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                        Console.WriteLine(new string('-', 90));
                                        Console.ResetColor();

                                        foreach (var item in PendingOrderList)
                                        {
                                            Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: ${item.Price} \nType of fuel: {item.Type}");
                                        }
                                    }
                                    else if (carFuelInput1 == "Diesel")
                                    {
                                        Console.WriteLine("Please type the price that you think the car is.");
                                        decimal carPriceInput1 = decimal.Parse(Console.ReadLine());

                                        decimal con = carPriceInput1 % 100;
                                        decimal per = con * 5;
                                        decimal sumPrice = per + carPriceInput1;

                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine($"There is a %5 increase on the price for an Diesel car!");
                                        Console.ResetColor();

                                        PendingOrderList.Add(new PendingOrder(carManufacturerInput1, carModelInput1, sumPrice, carFuelInput1));

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(new string('-', 90));
                                        Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                        Console.WriteLine(new string('-', 90));
                                        Console.ResetColor();

                                        foreach (var item in PendingOrderList)
                                        {
                                            Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: ${item.Price} \nType of fuel: {item.Type}");
                                        }
                                    }

                                    else if (carFuelInput1 == "Electric")
                                    {

                                        Console.WriteLine("Please type the price that you think the car is.");
                                        decimal carPriceInput1 = decimal.Parse(Console.ReadLine());

                                        decimal con = carPriceInput1 % 100;
                                        decimal per = con * 15;
                                        decimal sumPrice = per + carPriceInput1;

                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine($"There is a %15 increase on the price for an Electric car!");
                                        Console.ResetColor();

                                        PendingOrderList.Add(new PendingOrder(carManufacturerInput1, carModelInput1, sumPrice, carFuelInput1));

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(new string('-', 90));
                                        Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                        Console.WriteLine(new string('-', 90));
                                        Console.ResetColor();

                                        foreach (var item in PendingOrderList)
                                        {
                                            Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: ${item.Price} \nType of fuel: {item.Type}");
                                        }
                                    }
                                }

                                else if (car.Manufacturer == carManufacturerInput && car.Model == carModelInput && car.TypeOfFuel == carFuelInput && car.Price == carPriceInput)
                                {
                                    PendingOrderList.Add(new PendingOrder(carManufacturerInput, carModelInput, carPriceInput, carFuelInput));

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(new string('-', 90));
                                    Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                    Console.WriteLine(new string('-', 90));
                                    Console.ResetColor();

                                    foreach (var item in PendingOrderList)
                                    {
                                        Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: {item.Price} \nType of fuel: {item.Type}");
                                    }
                                }
                            }

                            break;
                        #endregion

                        #region VanInputs
                        case 2:

                            Console.WriteLine("You can choose a van from the ones in the catalog, or you can place an order.");
                            Console.WriteLine("Please choose the van manufacturer.");
                            string vanManufacturerInput = Console.ReadLine();
                            Console.WriteLine("Please choose the model of the van.");
                            string vanModelInput = Console.ReadLine();
                            Console.WriteLine("Please type the price that you think the van is.");
                            decimal vanPriceInput = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Please choose the payload of the van.");
                            string vanPayloadInput = Console.ReadLine();

                            if (CatalogList.Vans.Where(x => x.Manufacturer == vanManufacturerInput && x.Model == vanModelInput && x.Price == vanPriceInput && x.Payload == vanPayloadInput) != null)
                            {
                                PendingOrderList.Add(new PendingOrder(vanManufacturerInput, vanModelInput, vanPriceInput, vanPayloadInput));

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(new string('-', 90));
                                Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                Console.WriteLine(new string('-', 90));
                                Console.ResetColor();

                                foreach (var item in PendingOrderList)
                                {
                                    Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: {item.Price} \nPayload : {item.Type}");
                                }
                            }

                            else if (CatalogList.Vans.Where(x => x.Manufacturer != vanManufacturerInput || x.Model != vanModelInput || x.Price != vanPriceInput || x.Payload != vanPayloadInput) != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(new string('-', 90));
                                Console.WriteLine("We need to place an order the car is not in the inventory!!!");
                                Console.WriteLine(new string('-', 90));
                                Console.ResetColor();

                                Console.WriteLine("Please choose the manufacturer of the van.");
                                string vanManufacturerInput1 = Console.ReadLine();
                                Console.WriteLine("Please choose the model of the van.");
                                string vanModelInput1 = Console.ReadLine();
                                Console.WriteLine("Please type the price that you think the van is.");
                                decimal vanPriceInput1 = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Please choose the payload of the van.");
                                string vanPayloadInput1 = Console.ReadLine();

                                PendingOrderList.Add(new PendingOrder(vanManufacturerInput1, vanModelInput1, vanPriceInput1, vanPayloadInput1));

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(new string('-', 90));
                                Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                Console.WriteLine(new string('-', 90));
                                Console.ResetColor();

                                foreach (var item in PendingOrderList)
                                {
                                    Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: {item.Price} \nPayload : {item.Type}");
                                }
                            }

                            break;
                        #endregion

                        #region TruckInputs
                        case 3:

                            Console.WriteLine("You can choose a truck from the ones in the catalog, or you can place an order.");
                            Console.WriteLine("Please choose the truck manufacturer.");
                            string truckManufacturerInput = Console.ReadLine();
                            Console.WriteLine("Please choose the model of the truck.");
                            string truckModelInput = Console.ReadLine();
                            Console.WriteLine("Please type the price the price of the truck.");
                            decimal truckPriceInput = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Please choose the number of trailers for the truck.\nPlease note that if you choose No Trailer the price will be standard.\nIf You choose One Trailer the price is plus $3000 \nIf you choose Two Trailers you get a 10% discount on the second one.");
                            string truckTrailerInput = Console.ReadLine();

                            if (CatalogList.Trucks.Where(x => x.Manufacturer == truckManufacturerInput && x.Model == truckModelInput && x.Price == truckPriceInput && x.NumberOfTrailers == truckTrailerInput) != null)
                            {
                                PendingOrderList.Add(new PendingOrder(truckManufacturerInput, truckModelInput, truckPriceInput, truckTrailerInput));

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(new string('-', 90));
                                Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                Console.WriteLine(new string('-', 90));
                                Console.ResetColor();

                                foreach (var item in PendingOrderList)
                                {
                                    Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: ${item.Price} \nPayload : {item.Type}");
                                }
                            }

                            if (CatalogList.Trucks.Where(x => x.Manufacturer != truckManufacturerInput && x.Model != truckModelInput && x.Price != truckPriceInput && x.NumberOfTrailers != truckTrailerInput) != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(new string('-', 90));
                                Console.WriteLine("We need to place an order the truck is not in the inventory!!!");
                                Console.WriteLine(new string('-', 90));
                                Console.ResetColor();

                                Console.WriteLine("Please choose the manufacturer of the truck.");
                                string truckManufacturerInput1 = Console.ReadLine();
                                Console.WriteLine("Please choose the model of the truck.");
                                string truckModelInput1 = Console.ReadLine();
                                Console.WriteLine("Please type the price for the truck.");
                                decimal truckPriceInput1 = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Please choose the number of trailers.");
                                string truckTrailerInput1 = Console.ReadLine();

                                if (truckTrailerInput1 == "No Trailer")
                                {
                                    PendingOrderList.Add(new PendingOrder(truckManufacturerInput1, truckModelInput1, truckPriceInput1, truckTrailerInput1));

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(new string('-', 90));
                                    Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                    Console.WriteLine(new string('-', 90));
                                    Console.ResetColor();

                                    foreach (var item in PendingOrderList)
                                    {
                                        Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: ${item.Price} \nPayload : {item.Type}");
                                    }
                                }
                                else if (truckTrailerInput1 == "One Trailer")
                                {
                                    int oneTrailer = 3000;
                                    decimal priceWithOneTrailer = truckPriceInput1 + oneTrailer;

                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine($"There is a $3000 increase on the price for One Trailer!");
                                    Console.ResetColor();

                                    PendingOrderList.Add(new PendingOrder(truckManufacturerInput1, truckModelInput1, priceWithOneTrailer, truckTrailerInput1));

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(new string('-', 90));
                                    Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                    Console.WriteLine(new string('-', 90));
                                    Console.ResetColor();

                                    foreach (var item in PendingOrderList)
                                    {
                                        Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: ${item.Price} \nPayload : {item.Type}");
                                    }
                                }
                                else if (truckTrailerInput1 == "Two Trailers")
                                {
                                    int oneTrailer = 3000;

                                    decimal priceWithOneTrailer = truckPriceInput1 + oneTrailer;
                                    decimal temp = (oneTrailer % 100) * 10;
                                    decimal discount = oneTrailer - temp;
                                    decimal priceWithTwoTrailers = priceWithOneTrailer + discount;

                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine($"There is a %10 discount for the second trailer!");
                                    Console.ResetColor();

                                    PendingOrderList.Add(new PendingOrder(truckManufacturerInput1, truckModelInput1, priceWithTwoTrailers, truckTrailerInput1));

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(new string('-', 90));
                                    Console.WriteLine("Thank you very much your order has been received, and is Pending for Approval.");
                                    Console.WriteLine(new string('-', 90));
                                    Console.ResetColor();

                                    foreach (var item in PendingOrderList)
                                    {
                                        Console.WriteLine($"Here is your order \nManufacturer : {item.Manufacturer} \nModel: {item.Model} \nPrice: ${item.Price} \nPayload : {item.Type}");
                                    }
                                }
                            }
                            break;
                            #endregion
                    }
                }

                if (LoginSalesEmployee.Role == Enum_Role.SalesEmployee)
                {
                    //SalesEmployee.SeeTheCustumerList(CustomerList);

                    Console.WriteLine("To view the list of pending orders press 1.");
                    int numberInput = int.Parse(Console.ReadLine());

                    switch (numberInput)
                    {
                        case 1:
                            SalesEmployee.SeePendingOrderList(PendingOrderList);

                            Console.WriteLine(new string('-', 90));
                            Console.WriteLine("To Decline the order please write Decline, and then please write the type of the vehicle, and all the characteristics.");
                            Console.WriteLine(new string('-', 90));
                            Console.WriteLine("To Approve the order please write Approve and the order will be moved to the Order List.");
                            Console.WriteLine(new string('-', 90));

                            string statusInput = Console.ReadLine();

                            if (statusInput == "Decline")
                            {
                                Console.WriteLine($"Please Write the type of the vehicle.");
                                string typeInput = Console.ReadLine();
                            }

                            break;
                    }
                }

                break;
            }



        }

    }
}

