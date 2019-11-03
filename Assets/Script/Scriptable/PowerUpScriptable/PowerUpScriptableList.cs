using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpScriptableList", menuName = "ScriptableObjects/PowerUps/NewPowerUpScriptableList")]
public class PowerUpScriptableList : ScriptableObject
{
    [SerializeField]
    public PowerUpScriptable[] PowerUpArray;
}

