﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents on team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchp that this team came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        
    }
}
