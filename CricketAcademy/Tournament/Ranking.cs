using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketAcademy.Tournament
{
    public class Ranking
    {
        public decimal tournament_team_id { get; set; }
        public decimal point_to_add { get; set; }
        public decimal nrr_to_add { get; set; }
        public Enums.Result match_result { get; set; }
    }
}
