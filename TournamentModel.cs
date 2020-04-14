using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the Name of the tournament
        /// </summary>
        public string  TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents a list of the entered teams in the current Tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents a list of the tournament Prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents a list of list of matched up teams, which form an entire round.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
