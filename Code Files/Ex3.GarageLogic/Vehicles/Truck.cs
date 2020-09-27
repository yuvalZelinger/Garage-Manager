using System;
using System.Text;

namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class Truck : RegularVehicle
    {
        private const int k_NumberOfWheels = 12; 
        private const float k_MaximumEngineCapacity = (float)110; 
        private const eFuelType k_FuelType = eFuelType.Soler; 
        private const float k_WheelMaximumAirPressure = (float)26;
        private readonly bool m_TransfersDangerousMaterial;
        private readonly float m_CargoVolume;

        public Truck(string i_ModelName, string i_LicenseNumber, string i_ManufacturerName, float i_CurrentAirPressure, float i_CurrentFuelQuantity, bool i_CarriesDangerousMaterial, float i_CargoSize)
        : base(i_ModelName, i_LicenseNumber, k_FuelType, i_CurrentFuelQuantity, k_MaximumEngineCapacity, k_NumberOfWheels )
        {
            m_TransfersDangerousMaterial = i_CarriesDangerousMaterial;
            m_CargoVolume = i_CargoSize;
            MakeWheelsList(i_ManufacturerName, i_CurrentAirPressure, k_WheelMaximumAirPressure); 
        }

        public override string VehicleDetails()
        {
            StringBuilder vehicleDetails = new StringBuilder();

            vehicleDetails.Append(base.VehicleDetails());
            vehicleDetails.Append(string.Format("Transfers Dangerous Material: {1} {0}Cargo Volume:{2}{0}", Environment.NewLine, m_TransfersDangerousMaterial.ToString(), m_CargoVolume));

            return vehicleDetails.ToString();
        }
    }
}
