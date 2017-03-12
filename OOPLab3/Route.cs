using System.Collections.Generic;
using System.Linq;

namespace OOPLab3
{
    public class Route
    {
        public VechileTypes VechileType { get; set; }
        public string Number { get; set; }
        public List<Stop> Stops { get; set; }
        public List<Vechile> Vechiles { get; set; }

        public Route(string number, List<Stop> stops, List<Vechile> vechiles)
        {
            Number = number;
            Stops = stops;
            Vechiles = vechiles;
            if (vechiles.Count != 0)
                VechileType = vechiles.ElementAt(0).VechileType;
        }

        public Route(string number)
        {
            Number = number;
            Stops = new List<Stop>();
        }
    }
}
