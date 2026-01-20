using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[System.Serializable]

public class TeamData
{
    public string TeamID;
    public string TeamName;
    public string TeamTag;

    public List<string> PlayerIDs = new();

    public List<string> startingRosterIDs = new();

    public int Ranking;
    public int SeriesWins;
    public int SeriesLosses;
    public int Points;
    public int GameWins;
    public int GameLosses;

    public static TeamData CreateTeam(GameState gameState, string teamID, string teamName, string teamTag, List<PlayerData> players)
    {
        TeamData team = new TeamData
        {
            TeamID = teamID,
            TeamName = teamName,
            TeamTag = teamTag,

            SeriesWins = 0,
            SeriesLosses = 0,
            Points = 0,
            GameWins = 0,
            GameLosses = 0
        };

        foreach (PlayerData player in players)
        {
            team.PlayerIDs.Add(player.PlayerID);
            if (team.startingRosterIDs.Count < 5)
            {
                team.startingRosterIDs.Add(player.PlayerID);
            }  
            player.CurrentTeamID = team.TeamID;
        }

        gameState.AllTeams[team.TeamID] = team;
        return team;
    }
}
