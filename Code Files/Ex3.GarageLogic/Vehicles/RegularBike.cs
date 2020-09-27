using System;
using System.Text;

namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class RegularBike : RegularVehicle
    { 
        private const int k_NumberOfWheels = 2;
        private const float k_MaximumEngineCapacity = (float)8; 
        private const eFuelType k_FuelType = eFuelType.Octan95; 
        private const float k_WheelMaximumAirPressure = (float)33;
        private Bike m_Bike;

        public RegularBike(string i_ModelName, string i_LicenseNumber, string i_ManufacturerName, float i_CurrentAirPressure, float i_CurrentFuelQuantity, eLicenseType i_LicenseType, int i_EngineVolume)
            : base(i_ModelName, i_LicenseNumber, k_FuelType, i_CurrentFuelQuantity, k_MaximumEngineCapacity, k_NumberOfWheels)
        {
            m_Bike = new Bike(i_LicenseType, i_EngineVolume);
            MakeWheelsList(i_ManufacturerName, i_CurrentAirPressure, k_WheelMaximumAirPressure);
        }
 
        public override string VehicleDetails()
        {
            StringBuilder vehicleDetails = new StringBuilder();

            vehicleDetails.Append(base.VehicleDetails());
            vehicleDetails.Append(string.Format("License Type: {1} {0}Engine Capacity:{2}{0}", Environment.NewLine, m_Bike.LicenseType, m_Bike.EngineCapacity));

            return vehicleDetails.ToString();
        }
    }
}
