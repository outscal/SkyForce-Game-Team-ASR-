using UnityEngine;
namespace SkyForce.Player
{
    public class PlayerModel
    {
        [SerializeField]
        public PlayerScriptableObject playerScriptableObject;
        public PlayerModel(PlayerScriptableObject playerScriptableObject)
        {
            PlayerName = playerScriptableObject.PlayerName;
            Speed = playerScriptableObject.Speed;
            Health = playerScriptableObject.Health;
            PlayerPrefab = playerScriptableObject.playerPrefab;


        }
        public PlayerModel(PowerUpScriptable powerUpScriptable)
        {
            PlayerName = powerUpScriptable.PlayerName;
            Speed = powerUpScriptable.Speed;
            Health = powerUpScriptable.Health;
            PlayerPrefab = null;
        }
        public string PlayerName { get; }
        public float Speed { get; }
        public float Health { get; set; }
        public PlayerView PlayerPrefab { get; }
    }

}

