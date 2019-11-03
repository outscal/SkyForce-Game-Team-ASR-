using SkyForce.Powerups;
using UnityEngine;
[CreateAssetMenu(fileName = "PowerUpScriptableObject", menuName = "ScriptableObjects/PowerUps/NewPowerUpScriptableObject")]
public class PowerUpScriptable : ScriptableObject
{
    public PowerUpType PowerUpType;
    public string PlayerName;
    public float Speed;
    public float Health;
    public PowerUpView ViewPrefab;
}
