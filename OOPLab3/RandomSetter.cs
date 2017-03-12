using System;
using System.Collections.Generic;

namespace OOPLab3
{
    class RandomSetter
    {
        readonly Random _rand = new Random();

        private readonly Dictionary<int, string> _modelsDictionary = new Dictionary<int, string>()
        {
            {0,"Toyota"}, {1,"Samsung"}, {2,"Богдан"}, {3, "Lada"}, {4,"ГАЗ"}, {5,"Audi"}, {6, "ЗИЛ"}, {7,"Волга"}, {8, "Marcedes-Benz"}, {9, "Honda" }
        };
        private readonly Dictionary<int, string> _numberDictionary = new Dictionary<int, string>()
        {
            {0,"AA 1343 AB"}, {1,"VASYA"}, {2,"1231234"}, {3, "AA 1117 CE"}, {4,"2384729378"}, {5,"138"}, {6, "AA 8649 HR"}, {7,"23-222"}, {8, "12-123"}, {9, "AA 7474 GH" }
        };
        private readonly Dictionary<int, VechileTypes> _typesDictionary = new Dictionary<int, VechileTypes>()
        {
            {0,VechileTypes.Taxi}, {1,VechileTypes.Bus}, {2,VechileTypes.Metro}, {3, VechileTypes.Train}, {4,VechileTypes.Tram}, {5,VechileTypes.Trolley}
        };
        private readonly Dictionary<int, string> _namesDictionary = new Dictionary<int, string>()
        {
            {0,"Поликлиника"}, {1,"Магазин"}, {2,"Дачная"}, {3, "Нью-таун"}, {4,"Рынок"}, {5,"Университет"}, {6, "Вокзальная"}, {7,"Надежда"}, {8, "Святошинская"}, {9, "Олимпийский" }
        };
        private readonly Dictionary<int, string> _citiesDictionary = new Dictionary<int, string>()
        {
            {0,"Киев"}, {1,"Киев"}, {2,"Харьков"}
        };
        private readonly Dictionary<int, string> _streetsDictionary = new Dictionary<int, string>()
        {
            {0,"Обуховская"}, {1,"Командорма Уборевича"}, {2,"Полевая"}, { 3,"Крещатик"}, {4,"8-я Садовая"}, {5,"Житомирская"}, {6, "Ивана Франка"}, {7,"Подлесная"}, {8, "Булаховского"}, {9, "Академика Ефремова" }
        };

        public void DestroyModel()
        {
            Program.DataRoutes = new List<Route>();
        }

        public void SetModel()
        {
            for (var j = 0; j < 10; j++)
            {
                string model = null;
                string number = null;
                Vechile vechile = null;
                string name = null;
                string city = null;
                string street = null;
                Stop stop = null;
                var stops = new List<Stop>();
                var vechiles = new List<Vechile>();
                Route route = null;

                var vechileType = _typesDictionary[_rand.Next(6)];
                for (var i = 0; i < 10; i++)
                {
                    model = _modelsDictionary[_rand.Next(10)];
                    number = _numberDictionary[_rand.Next(10)];
                    vechile = new Vechile(vechileType, number, model);
                    vechiles.Add(vechile);
                }
                for (var i = 0; i < 10; i++)
                {
                    name = _namesDictionary[_rand.Next(10)];
                    city = _citiesDictionary[_rand.Next(3)];
                    street = _streetsDictionary[_rand.Next(10)];
                    stop = new Stop(street, city, name);
                    stops.Add(stop);
                }
                route = new Route(j.ToString(), stops, vechiles);
                Program.DataRoutes.Add(route);
            }
        }
    }
}
