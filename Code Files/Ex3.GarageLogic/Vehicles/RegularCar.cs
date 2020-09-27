using System;
using System.Text;

namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{

    // $G$ DSN-001 (-10) There is no appropriate use of polymorphism. - this why so many parameters in the constructor
    public class RegularCar : RegularVehicle
    {
        private const int k_NumberOfWheels = 4; 
        private const float k_MaximumEngineCapacity = (float)55; 
        private const eFuelType k_FuelType = eFuelType.Octan96; 
        private const float k_WheelMaximumAirPressure = (float)31;
        private Car m_Car;

        public RegularCar(string i_ModelName, string i_LicenseNumber, string i_ManufacturerName, float i_CurrentAirPressure, float i_CurrentFuelQuantity, eColor i_Color, eNumberOfDoors i_NumberOfDoors)
            : base(i_ModelName, i_LicenseNumber, k_FuelType, i_CurrentFuelQuantity, k_MaximumEngineCapacity, k_NumberOfWheels )
        {
            m_Car = new Car(i_Color, i_NumberOfDoors);
            MakeWheelsList(i_ManufacturerName, i_CurrentAirPressure, k_WheelMaximumAirPressure);
        }
    
        public override string VehicleDetails()
        {
            StringBuilder vehicleDetails = new StringBuilder();

            vehicleDetails.Append(base.VehicleDetails());
            vehicleDetails.Append(string.Format("Color: {1} {0}Number Of Doors:{2}{0}", Environment.NewLine, m_Car.Color, m_Car.NumberOfDoors));

            return vehicleDetails.ToString();
        }
    }
}
