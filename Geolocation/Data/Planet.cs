using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geolocation.Data
{
    /// <summary>
    /// The Representation of a planet in LDGeolocation.
    /// </summary>
    public class Planet
    {
        /// <summary>
        /// The Name Of Planet
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// The Radius of Planet. Since Numbers in Nature seldom gets perfectly divided ,
        /// I decided to save both Radius and Diameter instead of Calculate it.
        /// </summary>
        public Decimal  Radius { get; set; }
        /// <summary>
        /// The Radius of Planet. Since Numbers in Nature seldom gets perfectly divided ,
        /// I decided to save both Radius and Diameter instead of Calculate it.
        /// </summary>
        public Decimal Diameter { get; set; }

    }
}
