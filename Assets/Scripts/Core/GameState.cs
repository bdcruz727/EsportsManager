using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameState
{
    // Each Player is stored as their PlayerID
    public Dictionary<string, PlayerData> AllPlayers = new();

    // Each Team is stored as their TeamID
    public Dictionary<string, TeamData> AllTeams = new();
}
