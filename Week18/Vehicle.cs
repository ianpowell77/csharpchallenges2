namespace Week18
{
    class Vehicle
    {
        public string type;
        public byte numberOfTires;
        public string year;
        public string model;

        public Vehicle(string type, byte numberOfTires, string year, string model)
        {
            this.type = type;
            this.numberOfTires = numberOfTires;
            this.year = year;
            this.model = model;
        }
    }
}
