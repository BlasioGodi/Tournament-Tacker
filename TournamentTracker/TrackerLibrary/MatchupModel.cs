using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupentryModel> Entries { get; set; }= new List<MatchupentryModel>();
        public TeamModel Winner { get; set; }

    }
}
