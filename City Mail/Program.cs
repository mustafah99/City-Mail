using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static System.Console;

namespace City_Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to City Mail.");

            Thread.Sleep(500);

            Clear();

            bool invalidCredentials = true;
            do
            {
                Write("Username: ");
                string username = ReadLine();
                Write("Password: ");
                string password = ReadLine();

                if (username == "admin" && password == "admin")
                {
                    Clear();

                    WriteLine("Logging in...");

                    Thread.Sleep(300);

                    Clear();

                    invalidCredentials = false;

                    WriteLine("Welcome Admin.");

                    Thread.Sleep(500);

                    Clear();
                }
                else
                {
                    Clear();

                    WriteLine("Logging in...");

                    Thread.Sleep(300);

                    Clear();

                    WriteLine("Invalid credentials, please try again.");

                    Thread.Sleep(2000);

                    Clear();
                }

            } while (invalidCredentials);

            CursorVisible = false;

            bool cityMailAdminTools = true;

            // To save all car information.
            List<Car> allCars = new List<Car>();

            List<Quadcopter> allQuadcopters = new List<Quadcopter>();

            List<senderDestination> allSenders = new List<senderDestination>();

            //senderDestination senderdestination = new senderDestination();

            //Quadcopter quadcopterVehicle = new Quadcopter();

            //Car vehicle = new Car();


            do
            {
                WriteLine("1. Delivery Units");

                WriteLine("2. Register Package");

                WriteLine("3. List Packages");

                WriteLine("4. Start Delivery");

                WriteLine("5. Log Out");

                ConsoleKeyInfo keyInput = ReadKey(true);

                Clear();

                switch (keyInput.Key)
                {
                    case ConsoleKey.D1:

                        Clear();

                        bool deliverySubmenu = true;

                        do
                        {
                            WriteLine("1. Register");

                            WriteLine("2. Search");

                            WriteLine("3. Go Back");

                            ConsoleKeyInfo newInput = ReadKey(true);

                            if (newInput.Key == ConsoleKey.D1)
                            {
                                Clear();

                                WriteLine("1. Car");

                                WriteLine("2. Quadcopter");

                                WriteLine("3. Go Back");

                                ConsoleKeyInfo choicesInput = ReadKey(true);

                                switch (choicesInput.Key)
                                {
                                    case ConsoleKey.D1:
                                        Clear();

                                        bool invalidCarCredentials = true;

                                        do
                                        {
                                            Car vehicle = new Car();

                                            Write("ID: ");
                                            vehicle.ID = ReadLine();

                                            Write("Capacity (kg): ");
                                            vehicle.capacityKg = ReadLine();

                                            Write("Reach (km): ");
                                            vehicle.reachKm = ReadLine();

                                            Write("Registration number: ");
                                            vehicle.registrationNumber = ReadLine();

                                            Clear();

                                            WriteLine($"ID: {vehicle.ID}");
                                            WriteLine($"Capacity (kg): {vehicle.capacityKg}");
                                            WriteLine($"Reach (km): {vehicle.reachKm}");
                                            WriteLine($"Registration number: {vehicle.registrationNumber}");

                                            WriteLine(" ");
                                            WriteLine("Is this correct? (Y)es (N)o");

                                            ConsoleKeyInfo yesNo = ReadKey(true);

                                            // I want to run a code here that checks if the registration number already exists
                                            if (yesNo.Key == ConsoleKey.Y)
                                            {
                                                allCars.Add(vehicle);

                                                Clear();

                                                WriteLine("Delivery unit registered");

                                                Thread.Sleep(2000);

                                                Clear();

                                                break;
                                            }
                                            else if (yesNo.Key == ConsoleKey.N)
                                            {
                                                Clear();
                                            }
                                            else
                                            {
                                                Clear();

                                                WriteLine("Invalid key pressed.");

                                                Thread.Sleep(2000);

                                                Clear();
                                            }
                                        } while (invalidCarCredentials);

                                        break;
                                    case ConsoleKey.D2:
                                        Clear();

                                        bool invalidQuadcopterCredentials = true;

                                        do
                                        {
                                            Quadcopter quadcopterVehicle = new Quadcopter();

                                            Write("ID: ");
                                            quadcopterVehicle.ID = ReadLine();

                                            Write("Capacity (kg): ");
                                            quadcopterVehicle.capacityKg = ReadLine();

                                            Write("Reach (km): ");
                                            quadcopterVehicle.reachKm = ReadLine();

                                            Write("Transponder ID: ");
                                            quadcopterVehicle.transponderID = ReadLine();

                                            Clear();

                                            WriteLine($"ID: {quadcopterVehicle.ID}");
                                            WriteLine($"Capacity (kg): {quadcopterVehicle.capacityKg}");
                                            WriteLine($"Reach (km): {quadcopterVehicle.reachKm}");
                                            WriteLine($"Registration number: {quadcopterVehicle.transponderID}");

                                            WriteLine(" ");
                                            WriteLine("Is this correct? (Y)es (N)o");

                                            ConsoleKeyInfo yesNo = ReadKey(true);

                                            // I want to run a code here that checks if the registration number already exists
                                            if (yesNo.Key == ConsoleKey.Y)
                                            {
                                                allQuadcopters.Add(quadcopterVehicle);

                                                Clear();

                                                WriteLine("Delivery unit registered");

                                                Thread.Sleep(2000);

                                                Clear();

                                                break;
                                            }
                                            else if (yesNo.Key == ConsoleKey.N)
                                            {
                                                Clear();
                                            }
                                            else
                                            {
                                                Clear();

                                                WriteLine("Invalid key pressed.");

                                                Thread.Sleep(2000);

                                                Clear();
                                            }
                                        } while (invalidQuadcopterCredentials);

                                        break;
                                    case ConsoleKey.D3:
                                        Clear();
                                        break;
                                }
                            }
                            else if (newInput.Key == ConsoleKey.D2)
                            {
                                Clear();

                                WriteLine("Choose vehicle from list to search for.");

                                WriteLine("1. Car");

                                WriteLine("2. Quadcopter");

                                ConsoleKeyInfo carOrQuadcopter = ReadKey(true);

                                if (carOrQuadcopter.Key == ConsoleKey.D1)
                                {
                                    Clear();

                                    Write("Search for Car by ID: ");

                                    string searchForCar = ReadLine();

                                    var c = allCars.FirstOrDefault(cars => cars.ID == searchForCar);

                                    if (c == null)
                                    {
                                        WriteLine("Unit not found");
                                    }
                                    else
                                    {
                                        WriteLine("Value found.");
                                        // write here all the information you want to display.
                                        WriteLine($"ID: {c.ID}");
                                        WriteLine($"Capacity (kg): {c.capacityKg}");
                                        WriteLine($"Reach (km): {c.reachKm}");
                                        WriteLine($"Transponder ID: {c.registrationNumber}");
                                        c.vehicleDeliveryForm();
                                    }

                                    ReadKey(true);

                                    Clear();

                                    break;
                                }
                                else if (carOrQuadcopter.Key == ConsoleKey.D2)
                                {
                                    Clear();

                                    Write("Search for Quadcopter by ID: ");

                                    string searchForQuadcopter = ReadLine();

                                    var c = allQuadcopters.FirstOrDefault(quad => quad.ID == searchForQuadcopter);

                                    if (c == null)
                                    {
                                        WriteLine("Unit not found");
                                    }
                                    else
                                    {
                                        WriteLine("Value found.");
                                        // write here all the information you want to display.
                                        WriteLine($"ID: {c.ID}");
                                        WriteLine($"Capacity (kg): {c.capacityKg}");
                                        WriteLine($"Reach (km): {c.reachKm}");
                                        WriteLine($"Transponder ID: {c.transponderID}");
                                        c.vehicleDeliveryForm();
                                    }

                                    ReadKey(true);

                                    Clear();

                                    break;
                                }
                            }
                            else if (newInput.Key == ConsoleKey.D3)
                            {
                                deliverySubmenu = false;

                                Clear();

                                break;
                            }
                        } while (deliverySubmenu);

                        break;
                    case ConsoleKey.D2:
                        Clear();

                        bool registeringSenderAndDestination = true;

                        do
                        {
                            senderDestination senderdestination = new senderDestination();

                            Write("Sender: ");
                            senderdestination.senderName = ReadLine();

                            Write("Destination: ");
                            senderdestination.destination = ReadLine();

                            Clear();

                            WriteLine($"Sender: {senderdestination.senderName}");
                            WriteLine($"Destination:  {senderdestination.destination}");

                            WriteLine(" ");
                            WriteLine("Is this correct? (Y)es (N)o");

                            ConsoleKeyInfo yesNo = ReadKey(true);

                            if (yesNo.Key == ConsoleKey.Y)
                            {
                                allSenders.Add(senderdestination);

                                Clear();

                                WriteLine("Package registered");

                                Thread.Sleep(2000);

                                Clear();

                                break;
                            }
                            else if (yesNo.Key == ConsoleKey.N)
                            {
                                Clear();
                            }
                            else
                            {
                                Clear();

                                WriteLine("Invalid key pressed.");

                                Thread.Sleep(2000);

                                Clear();
                            }
                        } while (registeringSenderAndDestination);

                        Clear();

                        break;
                    case ConsoleKey.D3:
                        Clear();

                        int id = 1;

                        WriteLine("ID    Destination                        Status");

                        WriteLine("------------------------------------------------------------------");

                        // List packages 
                        foreach (var sender in allSenders)
                        {
                            // write here all the information you want to display.
                            WriteLine($"{id++}     {sender.destination,-14}                     {sender.Status}");
                        }

                        ReadKey(true);

                        Clear();

                        break;
                    case ConsoleKey.D4:
                        Clear();

                        int ids = 1;

                        WriteLine("Starting delivery on pending packages...");

                        WriteLine("------------------------------------------------------------------");

                        WriteLine("ID    Destination                        Status");

                        WriteLine("------------------------------------------------------------------");

                        foreach (var sender in allSenders)
                        {
                            sender.Status = SenderStatus.Delivering;
                            WriteLine($"{ids++}     {sender.destination,-14}                     {sender.Status}");
                            sender.Status = SenderStatus.Delivered;
                        }

                        Thread.Sleep(4000);



                        Clear();

                        break;
                    case ConsoleKey.D5:
                        Clear();

                        WriteLine("Logging out...");

                        Thread.Sleep(1000);

                        cityMailAdminTools = false;

                        Environment.Exit(0);

                        break;
                }

            } while (cityMailAdminTools);
        }
    }
}
