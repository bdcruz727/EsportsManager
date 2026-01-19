using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static PlayerData;
using static TeamData;


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
            95, 95, 94, 93, 92, 94);

        PlayerData Canyon = CreatePlayer(gameState, "canyon", "Canyon", PlayerData.Role.Jungle, 24, "geng",
            PlayerData.PotentialTier.Generational, PlayerData.PotentialLikelihood.Exact,
            96, 93, 96, 96, 92, 94);

        PlayerData Chovy = CreatePlayer(gameState, "chovy", "Chovy", PlayerData.Role.Middle, 24, "geng",
            PlayerData.PotentialTier.Generational, PlayerData.PotentialLikelihood.Exact,
            97, 99, 98, 96, 88, 97);

        PlayerData Ruler = CreatePlayer(gameState, "ruler", "Ruler", PlayerData.Role.Bottom, 27, "geng",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Exact,
            96, 94, 95, 95, 92, 92);

        PlayerData Duro = CreatePlayer(gameState, "duro", "Duro", PlayerData.Role.Support, 23, "geng",
            PlayerData.PotentialTier.Superstar, PlayerData.PotentialLikelihood.Medium,
            93, 91, 91, 90, 89, 92);


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
        foreach (var team in gameState.AllTeams.Values) { 
            Debug.Log($" Team Name: {team.TeamName}");
            Debug.Log($" Players:");
            foreach (var id in team.PlayerIDs)
            {
                PlayerData Player = gameState.AllPlayers[id];
                Debug.Log($"{Player.PlayerName} - Role: {Player.PlayerRole} - Overall: {Mathf.Round((float)Player.Overall)} - {Player.potentialTier} ({Player.potentialLikelihood})");
            }
        }

      
    }


}
