using System;
using System.Text;

namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class RegularVehicle : Vehicle
    {
        protected readonly eFuelType r_FuelType;
        protected readonly float r_MaximumFuelQuantity;
        protected float m_CurrentFuelQuantity;

        public RegularVehicle(string i_ModelName, string i_LicenseNumber, eFuelType i_FuelType, float i_CurrentFuelQuantity, float i_MaximumFuelQuantity, int i_NumberOfWheels)
             : base(i_ModelName, i_LicenseNumber, i_NumberOfWheels)
        {
            r_FuelType = i_FuelType;
            m_CurrentFuelQuantity = i_CurrentFuelQuantity;
            r_MaximumFuelQuantity = i_MaximumFuelQuantity;
            CalculateRemainingEnergy(r_MaximumFuelQuantity, m_CurrentFuelQuantity);
        }

        public void FillGas(float i_RefuelingLiters, eFuelType i_FuelType)
        {
            if (r_FuelType == i_FuelType)
            {
                if (m_CurrentFuelQuantity + i_RefuelingLiters <= r_MaximumFuelQuantity)
                {
                    m_CurrentFuelQuantity += i_RefuelingLiters;
                    CalculateRemainingEnergy(r_MaximumFuelQuantity, m_CurrentFuelQuantity);
                }
                else
                {
                    throw new ValueOutOfRangeException(0, r_MaximumFuelQuantity - m_CurrentFuelQuantity);
                }
            }
            else
            {
                string message = string.Format("ArgumentException - Fuel type: {0} is  incorrect. the correct fuel type is {1}", i_FuelType, r_FuelType);
                throw new ArgumentException(message);
            }
        }

        public override string VehicleDetails()
        {
            StringBuilder regularVehicleDetails = new StringBuilder();
            regularVehicleDetails.Append(base.VehicleDetails());
            regularVehicleDetails.Append(string.Format("Fuel Type: {1}{0}Current Fuel Quantity: {2}{0}Maximum Fuel Quantity:{3}{0}", Environment.NewLine, r_FuelType, m_CurrentFuelQuantity, r_MaximumFuelQuantity));

            return regularVehicleDetails.ToString();
        }
    }
}
