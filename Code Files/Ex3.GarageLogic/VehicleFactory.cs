namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class VehicleFactory
    {
        public static RegularCar CreateNewRegularCar(string i_ModelName, string i_LicenseNumber, string i_ManufacturerName, float i_CurrentAirPressure, float i_CurrentFuelQuantity, eColor i_color, eNumberOfDoors i_NumberOfDoors)
        {
            return new RegularCar(i_ModelName, i_LicenseNumber, i_ManufacturerName, i_CurrentAirPressure, i_CurrentFuelQuantity, i_color, i_NumberOfDoors);
        }

        public static ElectricCar CreateNewElectricCar(string i_ModelName, string i_LicenseNumber, string i_ManufacturerName, float i_CurrentAirPressure, float i_CurrentBatteryLeft, eColor i_Color, eNumberOfDoors i_NumberOfDoors)
        {
            return new ElectricCar(i_ModelName, i_LicenseNumber, i_ManufacturerName, i_CurrentAirPressure, i_CurrentBatteryLeft, i_Color, i_NumberOfDoors);
        }

        public static RegularBike CreateNewRegularBike(string i_ModelName, string i_LicenseNumber, string i_ManufacturerName, float i_CurrentAirPressure, float i_CurrentFuelQuantity, eLicenseType i_LicenseType, int i_EngineVolume)
        {
            return new RegularBike(i_ModelName, i_LicenseNumber, i_ManufacturerName, i_CurrentAirPressure, i_CurrentFuelQuantity, i_LicenseType, i_EngineVolume);
        }

        public static ElectricBike CreateNewElectricBike(string i_ModelName, string i_LicenseNumber, string i_ManufacturerName, float i_CurrentAirPressure, float i_CurrentBatteryLeft, eLicenseType i_LicenseType, int i_EngineVolume)
        {
            return new ElectricBike(i_ModelName, i_LicenseNumber, i_ManufacturerName, i_CurrentAirPressure, i_CurrentBatteryLeft, i_LicenseType, i_EngineVolume);
        }

        public static Truck CreateNewTruck(string i_ModelName, string i_LicenseNumber, string i_ManufacturerName, float i_CurrentAirPressure, float i_CurrentFuelQuantity, bool i_CarriesDangerousMaterial, float i_CargoSize)
        {
            return new Truck(i_ModelName, i_LicenseNumber, i_ManufacturerName, i_CurrentAirPressure, i_CurrentFuelQuantity, i_CarriesDangerousMaterial, i_CargoSize);
        }
    }
}
