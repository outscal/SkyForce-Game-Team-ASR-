using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel 
{
    [SerializeField]
    public PlayerScriptableObject playerScriptableObject;
    public PlayerModel (PlayerScriptableObject tankScriptableObject){
        PlayerName = tankScriptableObject.PlayerName;
        Speed = tankScriptableObject.Speed;
        Health = tankScriptableObject.Health;
        PlayerPrefab = tankScriptableObject.playerPrefab;


    }
    public string PlayerName{ get; }
    public float Speed{get;}
    public float Health {get; set;}
    public PlayerView PlayerPrefab {get;}
}
