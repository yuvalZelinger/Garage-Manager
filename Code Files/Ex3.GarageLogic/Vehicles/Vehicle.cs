using System;
using System.Collections.Generic;
using System.Text;

namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class Vehicle
    {
        protected readonly string r_ModelName;
        protected readonly string r_LicenseNumber;
        protected readonly int r_NumberOfWheels;
        protected float m_EnergyRemaining;
        // $G$ DSN-999 (-3) This List should be readonly.
        protected List<Wheel> m_Wheels = new List<Wheel>();
       
        public Vehicle(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels)
        {
            r_ModelName = i_ModelName;
            r_LicenseNumber = i_LicenseNumber;
            r_NumberOfWheels = i_NumberOfWheels;
        }

        public string LicenseNumber
        {
            get { return r_LicenseNumber; }
        }

        public virtual string VehicleDetails()
        {
            StringBuilder vehicleDetails = new StringBuilder();

            vehicleDetails.Append(string.Format("Model Name: {1}{0}License Number: {2}{0}Energy Remaining (%): {3}{0}Wheels Details: Manufacture: {4}{0}Maximum Air Pressure: {5}{0},Current Air Pressure:{6}{0}", Environment.NewLine, r_ModelName, r_LicenseNumber, m_EnergyRemaining, m_Wheels[0].Manufacture, m_Wheels[0].MaximumAirPressure, m_Wheels[0].CurrentAirPressure));

            return vehicleDetails.ToString();
        }

        public void CalculateRemainingEnergy(float i_MaximumEnergy, float i_CurrentEnergy)
        {
            m_EnergyRemaining = (float)i_CurrentEnergy / (i_MaximumEnergy / 100f);
        }

        protected void MakeWheelsList(string i_ManufacturerName, float i_CurrentAirPressure, float i_WheelMaximumAirPressure)
        {
            for (int i = 0; i < r_NumberOfWheels; i++)
            {
                m_Wheels.Add(new Wheel(i_ManufacturerName, i_CurrentAirPressure, i_WheelMaximumAirPressure));
            }
        }

        public void InflateWheelsToMaximum()
        {
            foreach (Wheel wheel in m_Wheels)
            {
                wheel.InflateWheelToMaximum();
            }
        }
    }
}
