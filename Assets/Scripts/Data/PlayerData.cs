using Unity.VisualScripting;
using UnityEditor.MPE;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public enum PotentialTier
    {
        Legend,
        Generational,
        Franchise,
        Superstar,
        Starter,
        Depth,
        Fringe
    }

    public enum PotentialLikelihood
    {
        Low,
        Medium,
        High,
        Exact
    }

    public enum Role
    {
        Top,
        Jungle,
        Middle,
        Bottom,
        Support
    }


    // Metadata
    public string PlayerID;
    public string PlayerName;
    public Role PlayerRole;

    // Info
    public int Age;
    public string CurrentTeamID;

    // Potential
    public PotentialTier potentialTier;
    public PotentialLikelihood potentialLikelihood;

    // Stat Categories
    public double Macro; // Macro, Rotations, Objective Calls, Vision Control
    public double Laning; // Micro, Farming, Trading, Wave Control
    public double Mechanics; // Reaction Time, Combo Execution, Accuracy, Consistency
    public double Fighting; // Teamfight Execution, Positioning, Teamfight Adaptability
    public double Personality; // Clutch, Composure, Communication, Leadership
    public double Champions; // Draft Flexibility, Meta Resilience

    // Overall
    public double Overall;



    public static double CalculatePlayerOverall(double[] stats, Role playerRole)
    {
        double Overall = 0;
        double[] weights = { 0.20, 0.20, 0.20, 0.20, 0.10, 0.10 };
        // Macro, Laning, Mechanics, Fighting, Personality, Champions
        switch (playerRole)
        {
            case Role.Top:
                weights[0] = 0.15; // Macro
                weights[1] = 0.25; // Laning
                weights[2] = 0.10; // Mechanics
                weights[3] = 0.25; // Fighting
                weights[4] = 0.10; // Personality
                weights[5] = 0.15; // Champions
                break;

            case Role.Jungle:
                weights[0] = 0.30; // Macro
                weights[1] = 0.05; // Laning
                weights[2] = 0.20; // Mechanics
                weights[3] = 0.20; // Fighting
                weights[4] = 0.15; // Personality
                weights[5] = 0.10; // Champions
                break;

            case Role.Middle:
                weights[0] = 0.125; // Macro
                weights[1] = 0.25; // Laning
                weights[2] = 0.25; // Mechanics
                weights[3] = 0.20; // Fighting
                weights[4] = 0.125; // Personality
                weights[5] = 0.05; // Champions
                break;

            case Role.Bottom:
                weights[0] = 0.03; // Macro
                weights[1] = 0.25; // Laning
                weights[2] = 0.275; // Mechanics
                weights[3] = 0.275; // Fighting
                weights[4] = 0.15; // Personality
                weights[5] = 0.02; // Champions
                break;

            case Role.Support:
                weights[0] = 0.30; // Macro
                weights[1] = 0.10; // Laning
                weights[2] = 0.05; // Mechanics
                weights[3] = 0.20; // Fighting
                weights[4] = 0.20; // Personality
                weights[5] = 0.15; // Champions
                break;
        }
        

        for(int i = 0; i < 6; i++)
        {
            Overall += stats[i] * weights[i];
        }

        return Overall;
    }

    // Creates a Player
    public static PlayerData CreatePlayer(GameState gameState, string playerId, string playerName, Role playerRole, int age, string currentTeamID,
        PotentialTier potentialTier, PotentialLikelihood potentialLikelihood,
        double macro, double laning, double mechanics, double fighting, double personality, double champions
        )
    {
        PlayerData playerData = new();

        playerData.PlayerID = playerId;
        playerData.PlayerName = playerName;
        playerData.PlayerRole = playerRole;
        playerData.Age = age;
        playerData.CurrentTeamID = currentTeamID;
        playerData.potentialTier = potentialTier;
        playerData.potentialLikelihood = potentialLikelihood;

        playerData.Macro = macro;
        playerData.Laning = laning;
        playerData.Mechanics = mechanics;
        playerData.Fighting = fighting;
        playerData.Personality = personality;
        playerData.Champions = champions;

        double[] stats = new double[6];
        stats[0] = playerData.Macro;
        stats[1] = playerData.Laning;
        stats[2] = playerData.Mechanics;
        stats[3] = playerData.Fighting;
        stats[4] = playerData.Personality;
        stats[5] = playerData.Champions;

        playerData.Overall = CalculatePlayerOverall(stats, playerRole);

        gameState.AllPlayers[playerData.PlayerID] = playerData;
        return playerData;
    }



}
