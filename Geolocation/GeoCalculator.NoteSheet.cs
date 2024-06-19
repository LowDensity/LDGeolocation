using Geolocation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geolocation
{
    //This file is mainly used to store and manage Data Required for Calculation or Constants, such as Planet info .
    //
    public static partial class GeoCalculator
    {
        /// <summary>
        /// The Key For Default Planet.
        /// </summary>
        public static readonly String DEFAULT_PLANET = "Earth-" + Guid.NewGuid().ToString("N");
        private static Dictionary<String, Planet> Planets = CreateDefaultPlanet();

        private static Dictionary<string, Planet> CreateDefaultPlanet()
        {
            var d = new Dictionary<String, Planet>();
            d.Add(DEFAULT_PLANET,new Planet() { Name = DEFAULT_PLANET, Diameter = 12742000.0M, Radius = 6371000.0M });
            return d;
        }

        private static Planet planet;
        /// <summary>
        /// the planet which is being used to calculate.
        /// </summary>
        public static Planet CurrentPlanet { get { return planet; }  }
    }
}
