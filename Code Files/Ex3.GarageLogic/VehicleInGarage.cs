namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    internal class VehicleInGarage
    {
        private readonly string r_OwnerName;
        private readonly string r_OwnerPhoneNumber;
        private eVehicleStatus m_VehicleStatus;
        private Vehicle m_Vehicle;

        public VehicleInGarage(Vehicle i_vehicle, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            r_OwnerName = i_OwnerName;
            r_OwnerPhoneNumber = i_OwnerPhoneNumber;
            m_VehicleStatus = eVehicleStatus.DuringRepair;
            m_Vehicle = i_vehicle;
        }

        public Vehicle GarageVehicle
        {
            get { return m_Vehicle; }
        }

        public eVehicleStatus GarageVehicleStatus
        {
            get { return m_VehicleStatus; }
            set { m_VehicleStatus = value; }
        }
    }
}
