using System;
using System.Text;

namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class ElectricVehicle : Vehicle
    {
        private readonly float r_MaximumBatteryTimeHours;
        private float m_BatteryTimeRemainsHours;

        public ElectricVehicle(string i_ModelName, string i_LicenseNumber, float i_BatteryTimeRemains, float i_MaximumBatteryTime, int i_NumberOfWheels)
            : base(i_ModelName, i_LicenseNumber, i_NumberOfWheels)
        {
            m_BatteryTimeRemainsHours = i_BatteryTimeRemains;
            r_MaximumBatteryTimeHours = i_MaximumBatteryTime;
            CalculateRemainingEnergy(r_MaximumBatteryTimeHours, m_BatteryTimeRemainsHours);
        }

        public void ChargeVehicle(float i_MinutesOfCharging)
        {
            float hoursOfCharging = (float)(i_MinutesOfCharging / 60f);
            if (m_BatteryTimeRemainsHours + hoursOfCharging <= r_MaximumBatteryTimeHours)
            {
                m_BatteryTimeRemainsHours += hoursOfCharging;
                CalculateRemainingEnergy(r_MaximumBatteryTimeHours, m_BatteryTimeRemainsHours);
            }
            else
            {
                throw new ValueOutOfRangeException(0, r_MaximumBatteryTimeHours - m_BatteryTimeRemainsHours);
            }
        }

        public override string VehicleDetails()
        {
            StringBuilder electricVehicleDetails = new StringBuilder();

            electricVehicleDetails.Append(base.VehicleDetails());
            electricVehicleDetails.Append(string.Format("Current Battery Time Left: {1}{0}Maximum Battery Time: {2}{0}", Environment.NewLine, m_BatteryTimeRemainsHours, r_MaximumBatteryTimeHours));

            return electricVehicleDetails.ToString();
        }
    }
}
