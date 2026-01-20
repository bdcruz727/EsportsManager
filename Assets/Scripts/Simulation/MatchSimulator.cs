using UnityEngine;
using static GameData;
using static SeriesData;
using static PlayerData;
using System;

[System.Serializable]

public class MatchSimulator
{
    public static SeriesData SimulateGame(GameState gameState, TeamData team1, TeamData team2, GameType gameType)
    {
        SeriesData series = new SeriesData();
        


        return series;
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

    // Takes a gameType and calculates the pressure (for that team)
    private double CalculateGamePressure(GameType gameType, bool isFacingElimination)
    {
        double pressure = 0.15;
        double basePressure = 0.0;
        if (BasePressure.TryGetValue(gameType, out basePressure)) {
            pressure = basePressure;
            if (isFacingElimination)
            {
                pressure = basePressure + (1 - basePressure) * 1.15;
            }
        }
        pressure = Mathf.Min(Convert.ToSingle(pressure), Convert.ToSingle(1.0));
        return pressure;
    }

    // Calculates the Pressure modifier based on personality
    private double CalculatePersonalPressureModifier(PlayerData player, double pressure)
    {
        return 1.0 + ((player.Personality - 94) / 100) * pressure;
    } 

    private double GetRoleVariance(PlayerData.Role role)
    {
        switch (role)
        {
            case Role.Top:
                return UnityEngine.Random.Range(0.94f, 1.06f);

            case Role.Jungle:
                return UnityEngine.Random.Range(0.93f, 1.07f);

            case Role.Middle:
                return UnityEngine.Random.Range(0.92f, 1.08f);

            case Role.Bottom:
                return UnityEngine.Random.Range(0.90f, 1.10f);

            case Role.Support:
                return UnityEngine.Random.Range(0.96f, 1.04f);
            default:
                break;
        }
        return 1.0;
    }

    // Calculates the final performance of a player from their base, pressure, personality etc.
    public double CalculateFinalPlayerPerfomance(PlayerData player, GameType gameType, bool isFacingElimination) { 
        double basePerformance = CalculateBasePlayerPerformance(player);
        double basePressure = CalculateGamePressure(gameType, isFacingElimination);
        double personalPressureModifier = CalculatePersonalPressureModifier(player, basePressure);
        double roleVariance = GetRoleVariance(player.PlayerRole);

        double finalPerformance = Mathf.Round(Convert.ToSingle(basePerformance * personalPressureModifier * roleVariance));

        //Debug.Log($"{player.PlayerName}: {finalPerformance}");
        return finalPerformance;
    }
}
