using UnityEngine;
using static GameData;
using static SeriesData;
using static PlayerData;
using System;

[System.Serializable]

public class MatchSimulator
{
    public SeriesData SimulateSeries(GameState gameState, TeamData team1, TeamData team2, GameType gameType)
    {
        SeriesData series = new SeriesData();
        maxGames.TryGetValue(gameType, out int seriesLength);
        int winsNeeded = 2;
        if (seriesLength == 5)
        {
            winsNeeded = 3;
        }

        int team1Wins = 0;
        int team2Wins = 0;
        int gamesPlayed = 0;

        series.team1 = team1;
        series.team2 = team2;
        series.gameType = gameType;
        series.maxGames = seriesLength;
        series.winsNeeded = winsNeeded;
        series.seriesGames = new();
        series.winningTeamPerGame = new();


        while (team1Wins < winsNeeded && team2Wins < winsNeeded)
        {
            bool team1FacingElimination = false;
            bool team2FacingElimination = false;
            if (team1Wins == winsNeeded - 1)
            {
                team2FacingElimination = true;
            }
            if (team2Wins == winsNeeded - 1)
            {
                team1FacingElimination = true;
            }

            Debug.Log($"=== Simulating Game {gamesPlayed + 1} ===");
            GameData currentGame = SimulateGame(gameState, team1, team2, gameType, team1FacingElimination, team2FacingElimination);
            Debug.Log($"Game Winner: {currentGame.gameWinner.TeamTag}");
            series.winningTeamPerGame.Add(currentGame.gameWinner);
            if (currentGame.gameWinner.TeamID == team1.TeamID)
            {
                team1Wins++;
            }
            else
            {
                team2Wins++;
            }

            series.seriesGames.Add(currentGame);
            gamesPlayed++;

        }

        if (team1Wins == winsNeeded)
        {
            series.seriesWinner = team1;
            series.seriesLoser = team2;
            team1.SeriesWins++;
            team2.SeriesLosses++;
        }
        else
        {
            series.seriesWinner = team2;
            series.seriesLoser = team1;
            team2.SeriesWins++;
            team1.SeriesLosses++;
        }

        series.team1Wins = team1Wins;
        series.team2Wins = team2Wins;

        series.totalGamesPlayed = gamesPlayed;

        Debug.Log($"Series Winner: {series.seriesWinner.TeamTag}");
        Debug.Log($"{team1.TeamTag}: {series.team1Wins} | {team2.TeamTag}: {series.team2Wins}");
        Debug.Log($"Winner by Game:");
        int index = 1;
        foreach (var game in series.seriesGames)
        {
            Debug.Log($"Game {index}: {game.gameWinner.TeamTag}");
            index++;
        }

        return series;
    }

    private GameData SimulateGame(GameState gameState, TeamData team1, TeamData team2, GameType gameType, bool team1FacingElimination, bool team2FacingElimination)
    {
        GameData game = new GameData();

        double team1TotalPerformance = CalculateTeamPerformance(gameState, team1, gameType, team1FacingElimination);
        double team2TotalPerformance = CalculateTeamPerformance(gameState, team2, gameType, team2FacingElimination);

        double totalPerformance = team1TotalPerformance + team2TotalPerformance;

        double performanceDifference = team1TotalPerformance - team2TotalPerformance;
        double team1WinChance = 0.5 + performanceDifference * 0.008; //Change last value to change win increase per point difference
        Mathf.Clamp((float)team1WinChance, 0.05f, 0.95f);

        double gameRoll = CalculateGameRoll();

        if (gameRoll <= team1WinChance)
        {
            game.gameWinner = team1;
            game.gameLoser = team2;
            team1.GameWins++;
            team2.GameLosses++;
        }
        else
        {
            game.gameWinner = team2;
            game.gameLoser = team1;
            team2.GameWins++;
            team1.GameLosses++;
        }


        /*
        double team1WinChance = team1TotalPerformance / totalPerformance;
        double team2WinChance = 1.0 - team1WinChance;

        double gameRoll = CalculateGameRoll();

        //Debug.Log($"{team1.TeamTag} Win double: {team1WinChance}");
        //Debug.Log($"{team2.TeamTag} Win double: {team2WinChance}");

        TeamData winningTeam = team1;
        TeamData losingTeam = team2;

        if (gameRoll > team1WinChance * 100)
        {
            winningTeam = team2;
            losingTeam = team1;
        }
        */

        Debug.Log($"{team1.TeamTag} Performance: {team1TotalPerformance}");
        Debug.Log($"{team2.TeamTag} Performance: {team2TotalPerformance}");
        Debug.Log($"{team1.TeamTag} Win Chance: {team1WinChance * 100:F2}%");
        Debug.Log($"{team2.TeamTag} Win Chance: {(1-team1WinChance) * 100:F2}%");

        Debug.Log($"Total Performance: {totalPerformance}");
        Debug.Log($"Game Roll: {gameRoll}");
        

        game.team1 = team1;
        game.team2 = team2;
        game.gameType = gameType;

        //game.gameWinner = winningTeam;
        //game.gameLoser = losingTeam;
        //game.gameMVP = gameState.AllPlayers[game.gameWinner.startingRosterIDs[0]];


        return game;
    }

    private double CalculateGameRoll()
    {
        return UnityEngine.Random.value;
    }

    private double CalculateTeamPerformance(GameState gameState, TeamData team, GameType gameType, bool isFacingElimination) {
        double total = 0;
        Debug.Log($"= {team.TeamTag} Performance =");
        foreach (var playerID in team.startingRosterIDs)
        {
            PlayerData player = gameState.AllPlayers[playerID];
            double performance = CalculateFinalPlayerPerfomance(player, gameType, isFacingElimination);
            Debug.Log($"{player.PlayerName} Performance: {performance}");
            total += performance;
        }

        return total;
    }


    

    // Takes a player and outputs their raw performance based on their stats
    private double CalculateBasePlayerPerformance(PlayerData player)
    {
        double[] weights = GetRoleWeights(player.PlayerRole);
        // Macro, Laning, Mechanics, Fighting, Personality, Champions
        double[] stats = { player.Macro, player.Laning, player.Mechanics, player.Fighting, player.Personality, player.Champions };

        double sum = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            sum += stats[i] * weights[i];
        }

        return sum;
    }

    // Takes a gameType and calculates the pressure (team wide)
    private double CalculateGamePressure(GameType gameType)
    {
        double pressure = 0.15;
        if (BasePressure.TryGetValue(gameType, out double basePressure)) {
            pressure = basePressure;
  
        }
        pressure = Mathf.Min((float)pressure, 1.0f);
        return pressure;
    }

    // Calculates the Pressure modifier based on an individual's personality and if elimination game
    private double CalculatePersonalPressureModifier(PlayerData player, double pressure, bool isFacingElimination)
    {
        double effectivePressure = pressure;
        if (isFacingElimination)
        {
            effectivePressure *= 1.15;
            // May add changes to pressure based on traits (i.e clutch or choker)
        }
        double personalPressure = 1.0 + ((player.Personality - 95) / 100) * effectivePressure;
        

        return personalPressure;
    } 

    private double GetRoleVariance(Role role)
    {
        switch (role)
        {
            case Role.Top:
                return UnityEngine.Random.Range(0.96f, 1.04f);

            case Role.Jungle:
                return UnityEngine.Random.Range(0.95f, 1.05f);

            case Role.Middle:
                return UnityEngine.Random.Range(0.94f, 1.06f);

            case Role.Bottom:
                return UnityEngine.Random.Range(0.92f, 1.08f);

            case Role.Support:
                return UnityEngine.Random.Range(0.98f, 1.02f);
            default:
                break;
        }
        return 1.0;
    }

    // Calculates the final performance of a player from their base, pressure, personality etc.
    public double CalculateFinalPlayerPerfomance(PlayerData player, GameType gameType, bool isFacingElimination) { 
        double basePerformance = CalculateBasePlayerPerformance(player);
        double basePressure = CalculateGamePressure(gameType);
        double personalPressureModifier = CalculatePersonalPressureModifier(player, basePressure, isFacingElimination);
        double roleVariance = GetRoleVariance(player.PlayerRole);
        //double pressurePerformance = Mathf.Round(Convert.ToSingle(basePerformance * personalPressureModifier));
        //double prePressurePerformance = Mathf.Round(Convert.ToSingle(basePerformance));
        
        double finalPerformance = Mathf.Round(Convert.ToSingle(basePerformance * personalPressureModifier * roleVariance));
        //Debug.Log($"Pre Pressure Performance - {player.PlayerName}: {prePressurePerformance}");
        //Debug.Log($"Pre Variance Performance - {player.PlayerName}: {pressurePerformance}");

        return finalPerformance;
    }
}
