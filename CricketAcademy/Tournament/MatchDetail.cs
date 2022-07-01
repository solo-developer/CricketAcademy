using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketAcademy.Tournament
{
    public class MatchDetail
    {
        public decimal team_id { get; set; }
        public decimal opposition_team_id { get; set; }

        public bool is_toss_won { get; set; }
        public bool is_bowling_first { get; set; }
        public Enums.Result match_result { get; set; }

        public DateTime match_date { get; set; }
        public string nep_match_date { get; set; }

        public int overs_bowled { get; set; }
        public int balls_bowled { get; set; }
        public int runs_conceeded { get; set; }
        public int wickets_taken { get; set; }


        public int overs_batted { get; set; }
        public int runs_scored { get; set; }
        public int balls_batted { get; set; }
        public int wickets_lost { get; set; }
    }
}
