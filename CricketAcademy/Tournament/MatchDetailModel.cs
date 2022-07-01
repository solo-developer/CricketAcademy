using System;

namespace CricketAcademy.Tournament
{
    public class MatchDetailModel
    {

        public static void save(MatchDetail match_detail)
        {
            try
            {
                insertToDb(match_detail);
                MatchDetail oppositionTeamScores = buildOppositionTeamDetail(match_detail);
                insertToDb(oppositionTeamScores);

                updateTeamStanding(match_detail);
                updateTeamStanding(oppositionTeamScores);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void updateTeamStanding(MatchDetail match_detail)
        {
            decimal newRR = calculateNRR(match_detail);
            Ranking ranking = new Ranking();
            ranking.tournament_team_id = match_detail.team_id;
            if (match_detail.match_result == Enums.Result.draw)
            {
                ranking.point_to_add = 1;
            }
            else if (match_detail.match_result == Enums.Result.won)
            {
                ranking.point_to_add = 2;
            }
            else
                ranking.point_to_add = 0;

            ranking.nrr_to_add = newRR;
            ranking.match_result = match_detail.match_result;
            updateRankingInDb(ranking);
        }

        private static decimal calculateNRR(MatchDetail match_detail)
        {
            decimal runRate = 0;

            string sql = "SELECT overs FROM tournament WHERE tournament_id=(SELECT tournament_id FROM tournament_team WHERE tournament_team_id='" + match_detail.team_id + "')";

            decimal totalAvailableOvers = Convert.ToDecimal(Library.DataAccessLayer.Instance.ExecuteScalar(sql));

            string oversBatted = match_detail.overs_batted + "." + match_detail.balls_batted;

            decimal oversPlayed = Convert.ToDecimal(oversBatted);

            if (match_detail.balls_batted == 6)
            {
                match_detail.overs_batted = match_detail.overs_batted + 1;
            }

            bool isBattingFirst = !match_detail.is_bowling_first;
            bool hasPlayedFullOvers = match_detail.overs_batted == totalAvailableOvers;
            bool isAllOut = match_detail.wickets_lost == 10;

            if (!hasPlayedFullOvers && isAllOut)
            {
                oversPlayed = totalAvailableOvers;
            }

            #region     opposition 

            decimal oversPlayedByOpposition = Convert.ToDecimal(match_detail.overs_bowled + "." + match_detail.balls_bowled);

            bool isOpponentAllOut = match_detail.wickets_taken == 10;
            bool hasOpponentPlayedFull = match_detail.overs_bowled == totalAvailableOvers;

            if (!hasOpponentPlayedFull && isOpponentAllOut)
            {
                oversPlayedByOpposition = totalAvailableOvers;
            }

            #endregion

            runRate = (match_detail.runs_scored / oversPlayed) - (match_detail.runs_conceeded / oversPlayedByOpposition);

            return runRate;
        }

        private static MatchDetail buildOppositionTeamDetail(MatchDetail match_detail)
        {
            MatchDetail detail = new MatchDetail();
            detail.is_bowling_first = !match_detail.is_bowling_first;
            detail.is_toss_won = !match_detail.is_toss_won;

            if (match_detail.match_result == Enums.Result.won)
            {
                detail.match_result = Enums.Result.lost;
            }
            else if (match_detail.match_result == Enums.Result.lost)
            {
                detail.match_result = Enums.Result.won;
            }
            else
                detail.match_result = match_detail.match_result;


            detail.team_id = match_detail.opposition_team_id;
            detail.opposition_team_id = match_detail.team_id;
            detail.match_date = match_detail.match_date;
            detail.nep_match_date = match_detail.nep_match_date;

            detail.overs_batted = match_detail.overs_bowled;
            detail.balls_batted = match_detail.balls_bowled;
            detail.wickets_lost = match_detail.wickets_taken;

            detail.overs_bowled = match_detail.overs_batted;
            detail.balls_bowled = match_detail.balls_batted;
            detail.wickets_taken = match_detail.wickets_lost;

            detail.runs_conceeded = match_detail.runs_scored;
            detail.runs_scored = match_detail.runs_conceeded;

            return detail;
        }

        private static void insertToDb(MatchDetail detail)
        {
            string sql = "INSERT INTO team_match_detail(tournament_team_id,opposition_tournament_team_id,match_date,nep_match_date,overs_bowled,wickets_taken,balls_bowled,overs_batted,wickets_lost,balls_batted,match_result,is_bowling_first,is_toss_won,runs_scored,runs_conceeded) VALUES ('" + detail.team_id + "','" + detail.opposition_team_id + "','" + detail.match_date + "','" + detail.nep_match_date + "','" + detail.overs_bowled + "','" + detail.wickets_taken + "','" + detail.balls_bowled + "','" + detail.overs_batted + "','" + detail.wickets_lost + "','" + detail.balls_batted + "','" + detail.match_result + "','" + detail.is_bowling_first + "','" + detail.is_toss_won + "','" + detail.runs_scored + "','" + detail.runs_conceeded + "')";

            Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
        }

        private static void updateRankingInDb(Ranking ranking)
        {
            try
            {
                decimal won = ranking.match_result == Enums.Result.won ? 1:0;
                decimal lost = ranking.match_result == Enums.Result.lost ? 1 : 0;
                decimal draw = ranking.match_result == Enums.Result.draw ? 1 : 0;

                string sql = "UPDATE ranking SET matches_played=matches_played+1,won=won+" + won + ",lost=lost+" + lost + ",draw=draw+" + draw + ",points=points+" + ranking.point_to_add + ",net_run_rate=net_run_rate+" + ranking.nrr_to_add + " WHERE tournament_team_id='" + ranking.tournament_team_id + "'";

                Library.DataAccessLayer.Instance.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
