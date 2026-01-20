using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static PlayerData;
using static TeamData;
using static MatchSimulator;


public class GameInitializer : MonoBehaviour
{
    //public static GameState CreateNewGame()
    void Start()
    {
        GameState gameState = new GameState();

        // T1 Creation
        // Macro, Laning, Mechanics, Fighting, Personality, Champions
        PlayerData Doran = CreatePlayer(gameState, "doran", "Doran", PlayerData.Role.Top, 25, "t1",
            PlayerData.PotentialTier.Superstar, PlayerData.PotentialLikelihood.Exact,
            95, 93, 91, 92, 90, 90);

        PlayerData Oner = CreatePlayer(gameState, "oner", "Oner", PlayerData.Role.Jungle, 23, "t1",
            PlayerData.PotentialTier.Generational, PlayerData.PotentialLikelihood.Medium,
            95, 92, 94, 94, 94, 94);

        PlayerData Faker = CreatePlayer(gameState, "faker", "Faker", PlayerData.Role.Middle, 29, "t1",
            PlayerData.PotentialTier.Legend, PlayerData.PotentialLikelihood.Exact,
            99, 92, 86, 90, 99, 97);

        PlayerData Peyz = CreatePlayer(gameState, "peyz", "Peyz", PlayerData.Role.Bottom, 20, "t1",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Medium,
            88, 92, 95, 92, 86, 88);

        PlayerData Keria = CreatePlayer(gameState, "keria", "Keria", PlayerData.Role.Support, 23, "t1",
            PlayerData.PotentialTier.Generational, PlayerData.PotentialLikelihood.Medium,
            98, 96, 96, 95, 94, 98);


        List<PlayerData> T1Players = new List<PlayerData>
        {
            Doran, Oner, Faker, Peyz, Keria
        };

        TeamData T1 = CreateTeam(gameState, "t1", "T1", "T1", T1Players);

        // HLE Team Creation
        // Macro, Laning, Mechanics, Fighting, Personality, Champions
        PlayerData Zeus = CreatePlayer(gameState, "zeus", "Zeus", PlayerData.Role.Top, 21, "hle",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Medium,
            92, 95, 95, 94, 89, 93);

        PlayerData Kanavi = CreatePlayer(gameState, "kanavi", "Kanavi", PlayerData.Role.Jungle, 25, "hle",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Exact,
            93, 90, 91, 93, 88, 94);

        PlayerData Zeka = CreatePlayer(gameState, "zeka", "Zeka", PlayerData.Role.Middle, 23, "hle",
            PlayerData.PotentialTier.Superstar, PlayerData.PotentialLikelihood.High,
            91, 93, 95, 93, 89, 90);

        PlayerData Gumayusi = CreatePlayer(gameState, "gumayusi", "Gumayusi", PlayerData.Role.Bottom, 23, "hle",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Medium,
            90, 91, 96, 94, 88, 89);

        PlayerData Delight = CreatePlayer(gameState, "delight", "Delight", PlayerData.Role.Support, 23, "hle",
            PlayerData.PotentialTier.Superstar, PlayerData.PotentialLikelihood.Medium,
            94, 92, 89, 91, 91, 90);


        List<PlayerData> HLEPlayers = new List<PlayerData>
        {
            Zeus, Kanavi, Zeka, Gumayusi, Delight
        };

        TeamData HLE = CreateTeam(gameState, "hle", "Hanwha Life Esports", "HLE", HLEPlayers);


        // Gen.G Creation
        // Macro, Laning, Mechanics, Fighting, Personality, Champions
        PlayerData Kiin = CreatePlayer(gameState, "kiin", "Kiin", PlayerData.Role.Top, 26, "geng",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Exact,
            96, 96, 95, 95, 92, 95);

        PlayerData Canyon = CreatePlayer(gameState, "canyon", "Canyon", PlayerData.Role.Jungle, 24, "geng",
            PlayerData.PotentialTier.Generational, PlayerData.PotentialLikelihood.Exact,
            96, 93, 96, 96, 92, 94);

        PlayerData Chovy = CreatePlayer(gameState, "chovy", "Chovy", PlayerData.Role.Middle, 24, "geng",
            PlayerData.PotentialTier.Generational, PlayerData.PotentialLikelihood.Exact,
            98, 99, 98, 97, 88, 97);

        PlayerData Ruler = CreatePlayer(gameState, "ruler", "Ruler", PlayerData.Role.Bottom, 27, "geng",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Exact,
            97, 95, 96, 95, 92, 92);

        PlayerData Duro = CreatePlayer(gameState, "duro", "Duro", PlayerData.Role.Support, 23, "geng",
            PlayerData.PotentialTier.Superstar, PlayerData.PotentialLikelihood.Medium,
            94, 92, 91, 94, 89, 92);


        List<PlayerData> GENPlayers = new List<PlayerData>
        {
            Kiin, Canyon, Chovy, Ruler, Duro
        };

        TeamData GEN = CreateTeam(gameState, "geng", "Gen.G", "GEN", GENPlayers);


        // KT Creation
        // Macro, Laning, Mechanics, Fighting, Personality, Champions
        PlayerData PerfecT = CreatePlayer(gameState, "perfect", "PerfecT", PlayerData.Role.Top, 21, "kt",
            PlayerData.PotentialTier.Starter, PlayerData.PotentialLikelihood.Medium,
            85, 87, 86, 85, 86, 85);

        PlayerData Cuzz = CreatePlayer(gameState, "cuzz", "Cuzz", PlayerData.Role.Jungle, 26, "kt",
            PlayerData.PotentialTier.Superstar, PlayerData.PotentialLikelihood.Exact,
            89, 85, 87, 88, 89, 88);

        PlayerData Bdd = CreatePlayer(gameState, "bdd", "Bdd", PlayerData.Role.Middle, 26, "kt",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Exact,
            94, 93, 94, 91, 96, 93);

        PlayerData Aiming = CreatePlayer(gameState, "aiming", "Aiming", PlayerData.Role.Bottom, 25, "kt",
            PlayerData.PotentialTier.Superstar, PlayerData.PotentialLikelihood.Exact,
            88, 91, 92, 91, 86, 89);

        PlayerData Ghost = CreatePlayer(gameState, "ghost", "Ghost", PlayerData.Role.Support, 26, "kt",
            PlayerData.PotentialTier.Starter, PlayerData.PotentialLikelihood.Exact,
            87, 82, 80, 85, 92, 80);

        PlayerData Pollu = CreatePlayer(gameState, "pollu", "Pollu", PlayerData.Role.Support, 20, "kt",
            PlayerData.PotentialTier.Depth, PlayerData.PotentialLikelihood.Medium,
            82, 81, 83, 81, 80, 79);


        List<PlayerData> KTPlayers = new List<PlayerData>
        {
            PerfecT, Cuzz, Bdd, Aiming, Ghost, Pollu
        };

        TeamData KT = CreateTeam(gameState, "kt", "KT Rolster", "KT", KTPlayers);







        // To Access A Player
        // PlayerData midPlayer = gameState.AllPlayers["playerID"];
        // midPlayer.Mechanics += 1;

        //return gameState;


        // DEBUGGING
        foreach (var team in gameState.AllTeams.Values) {
            Debug.Log($" Team Name: {team.TeamName}");
            Debug.Log($" Players:");
            foreach (var id in team.PlayerIDs)
            {
                PlayerData Player = gameState.AllPlayers[id];
                Debug.Log($"{Player.PlayerName} - Role: {Player.PlayerRole} - Overall: {Mathf.Round((float)Player.Overall)} - {Player.potentialTier} ({Player.potentialLikelihood})");
            }
        }

        MatchSimulator matchSimulator = new MatchSimulator();

        /*
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Game {i + 1}:");
            // double chovyScore = matchSimulator.CalculateFinalPlayerPerfomance(Chovy, GameData.GameType.SeasonPlayoffsFinals, true);
            double doranScore = matchSimulator.CalculateFinalPlayerPerfomance(Doran, GameData.GameType.SeasonPlayoffsFinals, true);
            double onerScore = matchSimulator.CalculateFinalPlayerPerfomance(Oner, GameData.GameType.SeasonPlayoffsFinals, true);
            double fakerScore = matchSimulator.CalculateFinalPlayerPerfomance(Faker, GameData.GameType.SeasonPlayoffsFinals, true);
            double peyzScore = matchSimulator.CalculateFinalPlayerPerfomance(Peyz, GameData.GameType.SeasonPlayoffsFinals, true);
            double keriaScore = matchSimulator.CalculateFinalPlayerPerfomance(Keria, GameData.GameType.SeasonPlayoffsFinals, true);

            double perfectScore = matchSimulator.CalculateFinalPlayerPerfomance(PerfecT, GameData.GameType.SeasonPlayoffsFinals, true);
            double cuzzScore = matchSimulator.CalculateFinalPlayerPerfomance(Cuzz, GameData.GameType.SeasonPlayoffsFinals, true);
            double bddScore = matchSimulator.CalculateFinalPlayerPerfomance(Bdd, GameData.GameType.SeasonPlayoffsFinals, true);
            double aimingScore = matchSimulator.CalculateFinalPlayerPerfomance(Aiming, GameData.GameType.SeasonPlayoffsFinals, true);
            double ghostScore = matchSimulator.CalculateFinalPlayerPerfomance(Ghost, GameData.GameType.SeasonPlayoffsFinals, true);

            Debug.Log($"Doran {doranScore} | {perfectScore} PerfecT");
            Debug.Log($"Oner {onerScore} | {cuzzScore} Cuzz");
            Debug.Log($"Faker {fakerScore} | {bddScore} Bdd");
            Debug.Log($"Peyz {peyzScore} | {aimingScore} Aiming");
            Debug.Log($"Keria {keriaScore} | {ghostScore} Ghost");
        }
        */

        SeriesData s1 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);
        SeriesData s2 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);
        SeriesData s3 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);
        SeriesData s4 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);
        SeriesData s5 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);
        SeriesData s6 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);
        SeriesData s7 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);
        SeriesData s8 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);
        SeriesData s9 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);
        SeriesData s10 = matchSimulator.SimulateSeries(gameState, GEN, T1, GameData.GameType.SeasonPlayoffsFinals);


        SeriesData[] allSeries = { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };

        for (int i = 0; i < allSeries.Length; i++)
        {
            Debug.Log($"Series {i + 1} Winner: {allSeries[i].seriesWinner.TeamTag}");
        }

        Debug.Log("GEN Record");
        Debug.Log($"Series: {GEN.SeriesWins} - {GEN.SeriesLosses} | Games: {GEN.GameWins} - {GEN.GameLosses}");

        Debug.Log("T1 Record");
        Debug.Log($"Series: {T1.SeriesWins} - {T1.SeriesLosses} | Games: {T1.GameWins} - {T1.GameLosses}");



    }


}
