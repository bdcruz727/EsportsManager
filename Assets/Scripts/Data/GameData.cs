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
        CupPlayIn,
        CupPlayoffsR1,
        CupPlayoffsR2,
        CupPlayoffsR3,
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
        { GameType.CupPlayIn,        0.40 },
        { GameType.CupPlayoffsR1,    0.55 },
        { GameType.CupPlayoffsR2,    0.65 },
        { GameType.CupPlayoffsR3,    0.75 },
        { GameType.CupFinals,        0.90 },

        // Regular Season
        { GameType.Rounds12,        0.15 },
        { GameType.Rounds34,        0.25 },

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

    public TeamData team1;
    public TeamData team2;
    public GameType gameType;

    public TeamData gameWinner;
    public TeamData gameLoser;

}
