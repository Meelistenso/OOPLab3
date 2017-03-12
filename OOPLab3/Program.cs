using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPLab3
{

    static class Program
    {
        public static List<Route> DataRoutes = new List<Route>();
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AboutForm());
        }

        public static VechileTypes VechileTypeEquals(string str)
        {
            switch (str.Trim().ToLower())
            {
                case "троллейбус":
                    return VechileTypes.Trolley;
                case "автобус":
                    return VechileTypes.Bus;
                case "метро":
                    return VechileTypes.Metro;
                case "маршрутное такси":
                    return VechileTypes.Taxi;
                case "электропоезд":
                    return VechileTypes.Train;
                case "трамвай":
                    return VechileTypes.Tram;
                default:
                    return VechileTypes.NotSelected;
            }
        }

        public static string VechileTypeName(VechileTypes type)
        {
            switch (type)
            {
                case VechileTypes.Trolley:
                    return "Троллейбус";
                case VechileTypes.Bus:
                    return "Автобус";
                case VechileTypes.Metro:
                    return "Метро";
                case VechileTypes.Taxi:
                    return "Маршрутное такси";
                case VechileTypes.Train:
                    return "Электропоезд";
                case VechileTypes.Tram:
                    return "Трамвай";
                default:
                    return "Не выбрано";
            }
        }
    }
}
