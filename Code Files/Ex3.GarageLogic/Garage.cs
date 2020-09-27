using System.Collections.Generic;
using System.Text;

namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class Garage
    {

        // $G$ CSS-002 (-5) Bad members variable name (should be in the form of m_PascalCase).
        private List<VehicleInGarage> m_vehicleInGaragesList = new List<VehicleInGarage>();

        public void Add(Vehicle vehicle, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            m_vehicleInGaragesList.Add(new VehicleInGarage(vehicle, i_OwnerName, i_OwnerPhoneNumber));
        }


        // $G$ NTT-999 (-5) You should have use: Environment.NewLine instead of "\n".
        public string GetLicenseNumbers(eVehicleStatus i_VechileStatusFilter)
        {
            StringBuilder licenseNumbers = new StringBuilder();

            foreach (VehicleInGarage vehicle in m_vehicleInGaragesList)
            {
                if (vehicle.GarageVehicleStatus == i_VechileStatusFilter)
                {
                    licenseNumbers.Append(vehicle.GarageVehicle.LicenseNumber);
                    licenseNumbers.Append("\n");
                }
            }

            return licenseNumbers.ToString();
        }

        public string GetLicenseNumbers()
        {
            StringBuilder licenseNumbers = new StringBuilder();

            foreach (VehicleInGarage vehicle in m_vehicleInGaragesList)
            {
                licenseNumbers.Append(vehicle.GarageVehicle.LicenseNumber);
                licenseNumbers.Append("\n");
            }

            return licenseNumbers.ToString();
        }

        public void ChangeVehicleInGarageStatus(string i_LicenseNumber, eVehicleStatus i_NewVehicleStatus)
        {
            VehicleInGarage vehicle = findVehicleByLicenseNumber(i_LicenseNumber);

            vehicle.GarageVehicleStatus = i_NewVehicleStatus;
        }

        public void InflateWheelsToMaximum(string i_LicenseNumber)
        {
            VehicleInGarage vehicle = findVehicleByLicenseNumber(i_LicenseNumber);
            vehicle.GarageVehicle.InflateWheelsToMaximum();
        }

        public bool IsVehicleInGarage(string i_LicenseNumber)
        {
            return findVehicleByLicenseNumber(i_LicenseNumber) != null;
        }

        public string VehiclesInGarageDetails(string i_LicenseNumber)
        {
            StringBuilder vehicleInGarageDetails = new StringBuilder();
            VehicleInGarage vehicle = findVehicleByLicenseNumber(i_LicenseNumber);

            vehicleInGarageDetails.Append(vehicle.GarageVehicle.VehicleDetails());
            vehicleInGarageDetails.Append("Status in garage: " + vehicle.GarageVehicleStatus + "\n");
            vehicleInGarageDetails.Append("\n");

            return vehicleInGarageDetails.ToString();
        }

        public bool FillGasInRegularVehicle(string i_LicenseNumber, float i_FuelLitersToAdd, eFuelType i_FuelType)
        {
            VehicleInGarage vehicle = findVehicleByLicenseNumber(i_LicenseNumber);
            bool isFilledUp = false;

            if (vehicle.GarageVehicle is RegularVehicle)
            {
                RegularVehicle regularVehicle = vehicle.GarageVehicle as RegularVehicle;
                regularVehicle.FillGas(i_FuelLitersToAdd, i_FuelType);
                isFilledUp = true;
            }

            return isFilledUp;
        }

        public bool ChargeElectricVehicle(string i_LicenseNumber, float i_MinutesToCharge)
        {
            VehicleInGarage vehicle = findVehicleByLicenseNumber(i_LicenseNumber);
            bool isFilledUp = false;

            if (vehicle.GarageVehicle is ElectricVehicle)
            {
                ElectricVehicle electricVehicle = vehicle.GarageVehicle as ElectricVehicle;
                electricVehicle.ChargeVehicle(i_MinutesToCharge);
                isFilledUp = true;
            }

            return isFilledUp;
        }

        private VehicleInGarage findVehicleByLicenseNumber(string i_LicenseNumber)
        {
            VehicleInGarage vehicleToFind = null;
            foreach (VehicleInGarage vehicle in m_vehicleInGaragesList)
            {
                if (vehicle.GarageVehicle.LicenseNumber == i_LicenseNumber)
                {
                    vehicleToFind = vehicle;
                }
            }

            return vehicleToFind;
        }
    }
}