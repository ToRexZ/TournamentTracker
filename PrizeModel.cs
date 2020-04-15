using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the teams Placenumber
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the Name of the current place
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the total Prize
        /// </summary>
        public decimal Prizeamount { get; set; }

        /// <summary>
        /// Represents the percentage of the total prizeze
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
