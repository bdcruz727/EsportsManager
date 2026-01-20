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

    // Array of Length 5, 1 indicates victory for team 1, 2 for team 2, 0 for no game
    public int[] seriesHistory = new int[5];
}
