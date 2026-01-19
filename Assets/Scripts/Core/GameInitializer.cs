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
            94, 91, 90, 91, 88, 88);

        PlayerData Oner = CreatePlayer(gameState, "oner", "Oner", PlayerData.Role.Jungle, 23, "t1",
            PlayerData.PotentialTier.Generational, PlayerData.PotentialLikelihood.Medium,
            95, 92, 94, 94, 94, 94);

        PlayerData Faker = CreatePlayer(gameState, "faker", "Faker", PlayerData.Role.Middle, 29, "t1",
            PlayerData.PotentialTier.Legend, PlayerData.PotentialLikelihood.Exact,
            99, 92, 86, 90, 99, 97);

        PlayerData Peyz = CreatePlayer(gameState, "peyz", "Peyz", PlayerData.Role.Bottom, 20, "t1",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Low,
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
            89, 92, 94, 92, 87, 89);

        PlayerData Gumayusi = CreatePlayer(gameState, "gumayusi", "Gumayusi", PlayerData.Role.Bottom, 23, "hle",
            PlayerData.PotentialTier.Franchise, PlayerData.PotentialLikelihood.Medium,
            90, 91, 96, 94, 88, 89);

        PlayerData Delight = CreatePlayer(gameState, "delight", "Delight", PlayerData.Role.Support, 23, "hle",
            PlayerData.PotentialTier.Superstar, PlayerData.PotentialLikelihood.Medium,
            91, 88, 89, 90, 88, 89);


        List<PlayerData> HLEPlayers = new List<PlayerData>
        {
            Zeus, Kanavi, Zeka, Gumayusi, Delight
        };

        TeamData HLE = CreateTeam(gameState, "hle", "Hanwha Life Esports", "HLE", HLEPlayers);

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
