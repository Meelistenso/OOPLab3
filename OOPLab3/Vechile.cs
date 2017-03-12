namespace OOPLab3
{
    public enum VechileTypes
    {
        NotSelected,
        Bus,
        Tram,
        Metro,
        Taxi,
        Trolley,
        Train
    }

    public class Vechile
    {
        public Vechile(VechileTypes vechileType, string number, string model)
        {
            VechileType = vechileType;
            Number = number;
            Model = model;
        }

        public VechileTypes VechileType { get; set; }
        public string Number { get; set; }
        public string Model { get; set; }
    }
}
