using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static GameData;

public class SeriesData
{
    public TeamData team1;
    public TeamData team2;
    public GameType gameType;
    public int maxGames;
    public int winsNeeded;

    public TeamData seriesWinner;
    public TeamData seriesLoser;

    public int team1Wins;
    public int team2Wins;
    public int totalGamesPlayed;


    public List<TeamData> winningTeamPerGame;
    public List<GameData> seriesGames;
}
