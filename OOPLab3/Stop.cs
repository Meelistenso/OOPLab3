namespace OOPLab3
{
    public class Stop
    {
        public Stop(string street, string city, string name)
        {
            Street = street;
            City = city;
            Name = name;
        }

        public string Street { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
    }
}
