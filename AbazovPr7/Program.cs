using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbazovPr7
{
    class Program
    {
        /// <summary>
        /// Запускает вывод списка галактик.
        /// </summary>
        static void Main(string[] args)
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name = "Tadpole", MegaLightYears = 400, GalaxyType = new GType('S') },
                new Galaxy() { Name = "Pinwheel", MegaLightYears = 25, GalaxyType = new GType('S') },
                new Galaxy() { Name = "Cartwheel", MegaLightYears = 500, GalaxyType = new GType('L') },
                new Galaxy() { Name = "Small Magellanic Cloud", MegaLightYears = .2, GalaxyType = new GType('I') }
            };

            foreach (var galaxy in theGalaxies)
            {
                Console.WriteLine($"{galaxy.Name}  {galaxy.MegaLightYears} ({galaxy.GalaxyType.MyGType})");
            }
        }
    }

    /// <summary>
    /// Представляет модель галактики.
    /// </summary>
    public class Galaxy
    {
        public string Name { get; set; }
        public double MegaLightYears { get; set; }
        public GType GalaxyType { get; set; }
    }

    /// <summary>
    /// Описывает тип галактики.
    /// </summary>
    public class GType
    {
        public GType(char type) => MyGType = type;
        public char MyGType { get; set; }
    }
}