namespace B19_Ex03_Yuval_203328042_Yuval_316019900
{
    internal struct Car
    {
        private eColor r_Color;
        private eNumberOfDoors r_NumberOfDoors;

        public Car(eColor i_Color, eNumberOfDoors i_NumberOfDoors)
        {
            r_Color = i_Color;
            r_NumberOfDoors = i_NumberOfDoors;
        }

        public eColor Color
        {
            get { return r_Color; }
        }

        public eNumberOfDoors NumberOfDoors
        {
            get { return r_NumberOfDoors; }
        }
    }
}
