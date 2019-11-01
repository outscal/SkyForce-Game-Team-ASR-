using SkyForce.Player;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerScriptableObjects",menuName = "ScriptableObjects/Player/NewPlayerScriptableObject")]
public class PlayerScriptableObject : ScriptableObject
{
public string PlayerName;
public float Speed;
public float Health;
[SerializeField]
public PlayerView playerPrefab;
}
