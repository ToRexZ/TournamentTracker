﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the entry team
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the Winning team
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the current matchup round.
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
