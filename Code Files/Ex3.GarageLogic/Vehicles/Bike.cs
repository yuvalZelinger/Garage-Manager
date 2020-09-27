namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    internal struct Bike
    {
        private readonly eLicenseType r_LicenseType;
        private readonly int r_EngineCapacity;

        public Bike(eLicenseType i_LicenseType, int i_EngineCapacity)
        {
            r_LicenseType = i_LicenseType;
            r_EngineCapacity = i_EngineCapacity;
        }

        public eLicenseType LicenseType
        {
            get { return r_LicenseType; }
        }

        public int EngineCapacity
        {
            get { return r_EngineCapacity; }
        }
    }
}
