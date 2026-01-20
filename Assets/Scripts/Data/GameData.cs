using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

using System.Collections.Generic;

public class GameData
{
    public enum GameType
    {
        // Cup
        CupGroup,
        CupPlayInR1,
        CupPlayInR2,
        CupPlayInR3,
        CupPlayoffsR1,
        CupPlayoffsR2,
        CupPlayoffsR3,
        CupPlayoffsR4,
        CupFinals,
        CupFinalsR1,  
        
        // Regular Season
        Rounds12,
        Rounds34,

        // Road to MSI
        RoadToMSIR1,
        RoadToMSIR2,
        RoadToMSIR3,
        RoadToMSIR4,

        // Season Play-Ins
        SeasonPlayInR1,
        SeasonPlayInR2,

        // Season Playoffs
        SeasonPlayoffsR1,
        SeasonPlayoffsR2,
        SeasonPlayoffsR3,
        SeasonPlayoffsR4,
        SeasonPlayoffsFinals
    }

    public static readonly Dictionary<GameType, double> BasePressure = new Dictionary<GameType, double>()
    {
         // Cup
        { GameType.CupGroup,         0.25 },
        { GameType.CupPlayInR1,      0.30 },
        { GameType.CupPlayInR2,      0.35 },
        { GameType.CupPlayInR3,      0.40 },
        { GameType.CupPlayoffsR1,    0.50 },
        { GameType.CupPlayoffsR2,    0.60 },
        { GameType.CupPlayoffsR3,    0.70 },
        { GameType.CupPlayoffsR4,    0.80 },
        { GameType.CupFinals,        0.90 },

        // Regular Season
        { GameType.Rounds12,        0.10 },
        { GameType.Rounds34,        0.20 },

        // Road to MSI
        { GameType.RoadToMSIR1,      0.45 },
        { GameType.RoadToMSIR2,      0.55 },
        { GameType.RoadToMSIR3,      0.70 },
        { GameType.RoadToMSIR4,      0.80 },

        // Season Play-Ins
        { GameType.SeasonPlayInR1,   0.50 },
        { GameType.SeasonPlayInR2,   0.65 },

        // Season Playoffs
        { GameType.SeasonPlayoffsR1,     0.60 },
        { GameType.SeasonPlayoffsR2,     0.70 },
        { GameType.SeasonPlayoffsR3,     0.80 },
        { GameType.SeasonPlayoffsR4,     0.85 },
        { GameType.SeasonPlayoffsFinals, 0.95 }
    };

    public static readonly Dictionary<GameType, int> maxGames = new Dictionary<GameType, int>()
    {
         // Cup
        { GameType.CupGroup,         3 },
        { GameType.CupPlayInR1,      3 },
        { GameType.CupPlayInR2,      3 },
        { GameType.CupPlayInR3,      5 },
        { GameType.CupPlayoffsR1,    5 },
        { GameType.CupPlayoffsR2,    5 },
        { GameType.CupPlayoffsR3,    5 },
        { GameType.CupPlayoffsR4,    5 },
        { GameType.CupFinals,        5 },

        // Regular Season
        { GameType.Rounds12,        3 },
        { GameType.Rounds34,        3 },

        // Road to MSI
        { GameType.RoadToMSIR1,      5 },
        { GameType.RoadToMSIR2,      5 },
        { GameType.RoadToMSIR3,      5 },
        { GameType.RoadToMSIR4,      5 },

        // Season Play-Ins
        { GameType.SeasonPlayInR1,   5 },
        { GameType.SeasonPlayInR2,   5 },

        // Season Playoffs
        { GameType.SeasonPlayoffsR1,     5 },
        { GameType.SeasonPlayoffsR2,     5 },
        { GameType.SeasonPlayoffsR3,     5 },
        { GameType.SeasonPlayoffsR4,     5 },
        { GameType.SeasonPlayoffsFinals, 5 }
    };

    public TeamData team1;
    public TeamData team2;
    public GameType gameType;

    public TeamData gameWinner;
    public TeamData gameLoser;

    //public PlayerData gameMVP;

}
