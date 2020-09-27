using System;

namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class UI
    {
        internal static void PrintWelcome()
        {
            Console.WriteLine("Welcome to Gragae Managemnt System! Choose an option from the menu by typing its number: ");
        }

        internal static GarageRunner.eMainMenuSelection Menu()
        {
            Console.WriteLine(@"
Menu:
1. Add a new vehicle to garage
2. Show license numbers of vehicles in the garage
3. Change status of vehicle in the garage
4. Inflate air in vehicle's wheels to maximum capacity
5. Fill gas of a fuel-run vehicle
6. Charge battery of electric vehicle
7. Show details of vehicle in the garage:
8. Exit System:");

            int userChoice;
            bool isNumber = int.TryParse(Console.ReadLine(), out userChoice);

            if (!isNumber)
            {
                throw new FormatException();
            }
           
            return (GarageRunner.eMainMenuSelection)userChoice;
        }

        public static eVehicleType GetVehicleType()
        {
            Console.WriteLine(@"What type of vehicle do you want to add?
1. Fuel-Based Car
2. Fuel-Based Bike
3. Electric-Based Car
4. Electric-Based Bike
5. Truck");

            string selection = Console.ReadLine();
            eVehicleType selectionNumber = (eVehicleType)int.Parse(selection);

            return selectionNumber;
        }

        public static eColor GetVehicleColor()
        {
            Console.WriteLine(@"What color is the vehicle?
1. Red
2. Blue
3. Black
4. Gray");

            string selection = Console.ReadLine();
            eColor selectionNumber = (eColor)int.Parse(selection);

            return selectionNumber;
        }

        public static eNumberOfDoors GetVehicleNumberOfDoors()
        {
            Console.WriteLine(@"How many doors does a car have?
For Two doors press - 2
For Three doors press - 3
For Four doors press - 4
For Five doors press - 5");

            string selection = Console.ReadLine();
            eNumberOfDoors selectionNumber = (eNumberOfDoors)int.Parse(selection);

            return selectionNumber;
        }

        public static eLicenseType GetVehicleLicenseType()
        {
            Console.WriteLine(@"What is the license type?
1.A
2.A1
3.A2
4.B");

            string selection = Console.ReadLine();
            eLicenseType selectionNumber = (eLicenseType)int.Parse(selection);

            return selectionNumber;
        }

        internal static void PrintGivenString(string i_StringToPrint)
        {
            Console.WriteLine(i_StringToPrint);
        }

        public static string GetModel()
        {
            Console.WriteLine("Enter Model");

            return Console.ReadLine();
        }

        internal static string GetVehicleStatusFilter()
        {
            Console.WriteLine(@"Would you like to filter the results according to a specified vehicle status? If so choose status:
1. During Repair
2. Fixed
3. Paid
If you don't want to filter, press any other key");

            return Console.ReadLine();
        }

        internal static float GetMinutesToCharge()
        {
            Console.WriteLine("Enter How Much Time You Want to Charge (in minutes):");

            float minutesToCharge;
            bool isNumber = float.TryParse(Console.ReadLine(), out minutesToCharge);
            if(!isNumber)
            {
                throw new FormatException();
            }

            return minutesToCharge;
        }

        internal static int GetEngineCapacity()
        {
            Console.WriteLine("Enter the engine capacity:");

            int engineCapacity;
            bool isNumber = int.TryParse(Console.ReadLine(), out engineCapacity);
            if (!isNumber)
            {
                throw new FormatException();
            }

            return engineCapacity;
        }

        internal static eFuelType GetFuelType()
        {
            Console.WriteLine(@"Choose Fuel Type:
1. Octan95,
2. Octan96,
3. Octan98,
4. Soler");

            string selection = Console.ReadLine();
            eFuelType selectionNumber = (eFuelType)int.Parse(selection);

            return selectionNumber;
        }

        internal static float GetFuelQuantityToAdd()
        {
            Console.WriteLine("Enter How Many Litres of Fuel To Add:");
            float fuelQuantity;
            bool isNumber = float.TryParse(Console.ReadLine(), out fuelQuantity);

            if (!isNumber)
            {
                throw new FormatException();
            }

            return fuelQuantity;
        }

        public static string GetLicenseNumber()
        {
            Console.WriteLine("Enter License Number");

            return Console.ReadLine();
        }

        internal static eVehicleStatus GetNewVehicleStatus()
        {
            Console.WriteLine(@"What is the desired status of the vehicle?
1. During Repair
2. Fixed
3. Paid");

            string selection = Console.ReadLine();
            eVehicleStatus selectionNumber = (eVehicleStatus)int.Parse(selection);

            return selectionNumber;
        }

        public static string GetWheelManufacturerName()
        {
            Console.WriteLine("Enter Wheel Manufacturer Name");

            return Console.ReadLine();
        }

        public static bool HazardousMaterialsTransfer()
        {
            Console.WriteLine(@"Does transfer hazardous materials?
1. YES
2. NO");
            int userChoice;
            bool isNumber = int.TryParse(Console.ReadLine(), out userChoice);
            if (!isNumber)
            {
                throw new FormatException();
            }

            return userChoice == 1;
        }

        internal static float GetCargoVolume()
        {
            Console.WriteLine("Enter the volume of the cargo?");
            float cargoVolume;
            bool isNumber = float.TryParse(Console.ReadLine(), out cargoVolume);

            if (!isNumber)
            {
                throw new FormatException();
            }

            return cargoVolume;
        }

        public static float GetWheelCurrentAirPressure()
        {
            Console.WriteLine("Enter Wheel Current Air Pressure:");
            float currentAirPressure;
            bool isNumber = float.TryParse(Console.ReadLine(), out currentAirPressure);

            if (!isNumber)
            {
                throw new FormatException();
            }

            return currentAirPressure;
        }

        public static float GetCurrentBatteryRemaining()
        {
            Console.WriteLine("Enter Current Battery Remaining:");

            float currentBatteryRemaining;
            bool isNumber = float.TryParse(Console.ReadLine(), out currentBatteryRemaining);

            if (!isNumber)
            {
                throw new FormatException();
            }

            return currentBatteryRemaining;
        }

        public static string GetOwnerPhoneNumber()
        {
            Console.WriteLine("Enter Owner's Phone Number");

            return Console.ReadLine();
        }

        public static string GetOwnerName()
        {
            Console.WriteLine(@"Vehicle is entering the garage.
Enter Owner's Name");

            return Console.ReadLine();
        }

        internal static void PrintVehicleIsAlreadyInGarage()
        {
            Console.WriteLine("Vehicle is already in the garage (according to license number). Setting vehicle's status to 'being fixed'");
        }


        // $G$ CSS-013 (-5) Bad variable name (should be in the form of: i_CamelCase).
        internal static void PrintVehicleIsNotInGarage(string i_licenseNumber)
        {
            Console.WriteLine("License number: {0} was not found. Vehicle isnt in the garage", i_licenseNumber);
        }

        public static float GetCurrentFuelQuantity()
        {
            Console.WriteLine("Enter Current Fuel Quantity:");
            float currentFuelQuantity;
            bool isNumber = float.TryParse(Console.ReadLine(), out currentFuelQuantity);

            if (!isNumber)
            {
                throw new FormatException();
            }

            return currentFuelQuantity;
        }
    }
}
