namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class Wheel
    {
        private readonly string r_ManufacturerName;
        private readonly float r_MaximumAirPressure;
        private float m_CurrentAirPressure;

        public Wheel(string i_ManufacturerName, float i_CurrentAirPressure, float i_MaximumAirPressure)
        {
            r_ManufacturerName = i_ManufacturerName;
            m_CurrentAirPressure = i_CurrentAirPressure;
            r_MaximumAirPressure = i_MaximumAirPressure;
        }

        public string Manufacture
        {
            get { return r_ManufacturerName; }
        }

        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
        }

        public float MaximumAirPressure
        {
            get { return r_MaximumAirPressure; }
        }

        public void WheelInflating(float i_AirPressureToAdd)
        {
            if (m_CurrentAirPressure + i_AirPressureToAdd <= r_MaximumAirPressure)
            {
                m_CurrentAirPressure += i_AirPressureToAdd;
            }
            else
            {
                throw new ValueOutOfRangeException(0, r_MaximumAirPressure - m_CurrentAirPressure);
            }
        }

        public void InflateWheelToMaximum()
        {
            m_CurrentAirPressure = r_MaximumAirPressure;
        }
    }
}
