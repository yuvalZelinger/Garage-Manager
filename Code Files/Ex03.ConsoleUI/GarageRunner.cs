using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    public class GarageRunner
    {

        // $G$ NTT-999 (-5) This kind of field should be readonly.
        private Garage m_Garage = new Garage();

        internal enum eMainMenuSelection
        {
            AddNewVehicle = 1,
            ShowVehiclesLicenseNumbers,
            ChangeVehicleStatus,
            InflateAirToMaximum,
            FillGas,
            ChargeBattery,
            ShowVehicleDetails,
            ExitSystem
        }

        public void Run()
        {
            UI.PrintWelcome();

            while (true)
            {
                try
                {
                    eMainMenuSelection userChoice = UI.Menu();

                    switch (userChoice)
                    {
                        case eMainMenuSelection.AddNewVehicle:
                            AddNewVehicle();
                            break;
                        case eMainMenuSelection.ShowVehiclesLicenseNumbers:
                            ShowVehiclesLicenseNumbers();
                            break;
                        case eMainMenuSelection.ChangeVehicleStatus:
                            ChangeVehicleStatus();
                            break;
                        case eMainMenuSelection.InflateAirToMaximum:
                            InflateAirInWheelsToMaximum();
                            break;
                        case eMainMenuSelection.FillGas:
                            FillGas();
                            break;
                        case eMainMenuSelection.ChargeBattery:
                            ChargeBattery();
                            break;
                        case eMainMenuSelection.ShowVehicleDetails:
                            ShowVehicleDetails();
                            break;
                        case eMainMenuSelection.ExitSystem:
                            System.Environment.Exit(1);
                            break;
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Input format incorrect");
                }
            }
        }

        // $G$ CSS-010 (-5) Private methods should start with an lowercase letter.
        private void ChargeBattery()
        {
            string licenseNumber = UI.GetLicenseNumber();
            bool isFilledUp;

            try
            {
                if (m_Garage.IsVehicleInGarage(licenseNumber))
                {
                    isFilledUp = m_Garage.ChargeElectricVehicle(licenseNumber, UI.GetMinutesToCharge());
                    if (!isFilledUp)
                    {
                        Console.WriteLine("The vehicle is not an electric vehicle and therefore can not be Charged");
                    }
                    else
                    {
                        Console.WriteLine("Charged Battery completed successfully");
                    }
                }
                else
                {
                    UI.PrintVehicleIsNotInGarage(licenseNumber);
                }
            }
            catch (ValueOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input format is incorrect");
            }
        }

        // $G$ CSS-010 (-5) Private methods should start with an lowercase letter.
        private void FillGas()
        {
            string licenseNumber = UI.GetLicenseNumber();
            bool isFilledUp;

            try
            {
                if (m_Garage.IsVehicleInGarage(licenseNumber))
                {
                    isFilledUp = m_Garage.FillGasInRegularVehicle(licenseNumber, UI.GetFuelQuantityToAdd(), UI.GetFuelType());
                    if (!isFilledUp)
                    {
                        Console.WriteLine("The vehicle is not running on fuel vehicle and therefore can not be refuel");
                    }
                    else
                    {
                        Console.WriteLine("Fuel filling completed successfully");
                    }
                }
                else
                {
                    UI.PrintVehicleIsNotInGarage(licenseNumber);
                }
            }
            catch (ValueOutOfRangeException exception)
            {
                Console.WriteLine("Chosen amount is incorrect. The maximum amount that can be filled is {0}", exception.MaxValue);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input format is incorrect");
            }
        }

        private void InflateAirInWheelsToMaximum()
        {
            string licenseNumber = UI.GetLicenseNumber();
            if (m_Garage.IsVehicleInGarage(licenseNumber))
            {
                m_Garage.InflateWheelsToMaximum(licenseNumber);
                Console.WriteLine("Successfully inflate wheels to maximum");
            }
            else
            {
                UI.PrintVehicleIsNotInGarage(licenseNumber);
            }
        }

        private void ShowVehiclesLicenseNumbers()
        {
            string vehicleStatusFilter = UI.GetVehicleStatusFilter();
            if (vehicleStatusFilter == ((int)eVehicleStatus.DuringRepair).ToString() || vehicleStatusFilter == ((int)eVehicleStatus.Fixed).ToString() || vehicleStatusFilter == ((int)eVehicleStatus.Paid).ToString())
            {
                eVehicleStatus filteredStatus = (eVehicleStatus)int.Parse(vehicleStatusFilter);
                UI.PrintGivenString(m_Garage.GetLicenseNumbers(filteredStatus));
            }
            else
            {
                UI.PrintGivenString(m_Garage.GetLicenseNumbers());
            }
        }

        private void ChangeVehicleStatus()
        {
            string licenseNumber = UI.GetLicenseNumber();
            if (m_Garage.IsVehicleInGarage(licenseNumber))
            {
                eVehicleStatus newVehicleStatus = UI.GetNewVehicleStatus();
                m_Garage.ChangeVehicleInGarageStatus(licenseNumber, newVehicleStatus);
            }
            else
            {
                UI.PrintVehicleIsNotInGarage(licenseNumber);
            }
        }

        private void ShowVehicleDetails()
        {
            string licenseNumber = UI.GetLicenseNumber();
            if (m_Garage.IsVehicleInGarage(licenseNumber))
            {
                UI.PrintGivenString(m_Garage.VehiclesInGarageDetails(licenseNumber));
            }
            else
            {
                UI.PrintVehicleIsNotInGarage(licenseNumber);
            }
        }

        private void AddNewVehicle()
        {
            eVehicleType vehicleType = UI.GetVehicleType();
            Vehicle vehicle = null;
            string vehicleModel = UI.GetModel();
            string vehicleLicenseNumber = UI.GetLicenseNumber();

            if (m_Garage.IsVehicleInGarage(vehicleLicenseNumber))
            {
                UI.PrintVehicleIsAlreadyInGarage();
                m_Garage.ChangeVehicleInGarageStatus(vehicleLicenseNumber, eVehicleStatus.DuringRepair);
            }
            else
            {
                switch (vehicleType)
                {
                    case eVehicleType.RegularCar:
                        vehicle = VehicleFactory.CreateNewRegularCar(vehicleModel, vehicleLicenseNumber, UI.GetWheelManufacturerName(), UI.GetWheelCurrentAirPressure(), UI.GetCurrentFuelQuantity(), UI.GetVehicleColor(), UI.GetVehicleNumberOfDoors());
                        break;

                    case eVehicleType.ElectricCar:
                        vehicle = VehicleFactory.CreateNewElectricCar(vehicleModel, vehicleLicenseNumber, UI.GetWheelManufacturerName(), UI.GetWheelCurrentAirPressure(), UI.GetCurrentBatteryRemaining(), UI.GetVehicleColor(), UI.GetVehicleNumberOfDoors());
                        break;

                    case eVehicleType.RegularBike:
                        vehicle = VehicleFactory.CreateNewRegularBike(vehicleModel, vehicleLicenseNumber, UI.GetWheelManufacturerName(), UI.GetWheelCurrentAirPressure(), UI.GetCurrentFuelQuantity(), UI.GetVehicleLicenseType(), UI.GetEngineCapacity());
                        break;

                    case eVehicleType.ElectricBike:
                        vehicle = VehicleFactory.CreateNewElectricBike(vehicleModel, vehicleLicenseNumber, UI.GetWheelManufacturerName(), UI.GetWheelCurrentAirPressure(), UI.GetCurrentBatteryRemaining(), UI.GetVehicleLicenseType(), UI.GetEngineCapacity());
                        break;

                    case eVehicleType.Truck:
                        vehicle = VehicleFactory.CreateNewTruck(vehicleModel, vehicleLicenseNumber, UI.GetWheelManufacturerName(), UI.GetWheelCurrentAirPressure(), UI.GetCurrentFuelQuantity(), UI.HazardousMaterialsTransfer(), UI.GetCargoVolume());
                        break;

                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }

                m_Garage.Add(vehicle, UI.GetOwnerName(), UI.GetOwnerPhoneNumber());
                Console.WriteLine("The vehicle enters the garage successfully!");
            }
        }
    }
}
