using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptables", menuName = "ScriptableObjects/EnemyScriptables/NewEnemyScriptableObject")]
public class EnemyScriptables : ScriptableObject
{
    public EnemyType Type;
    public bool IsShooting;
    public bool ChangeMovement;
    public float LeftOffsetValue;
    public float RightOffsetValue;
    public bool IsRotating;
    public float Speed;
    public float CollideDamage;
    public float Health;
    
}
