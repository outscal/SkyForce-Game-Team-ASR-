using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptables", menuName = "ScriptableObjects/EnemyScriptables/NewEnemyScriptableObject")]
public class EnemyScriptables : ScriptableObject
{
    public EnemyType Type;
    public bool IsShooting;
    public bool ChangeMovement;
    public bool MoveToLeftFirst;
    [Range(0,1.5f)]
    public float LeftOffsetValue;
    [Range(0, 1.5f)]
    public float RightOffsetValue;
    public bool SizeIncreaseDecrease;
    public bool IsRotating;
    public float RotateByAngleValue;
    public bool RotateByAxisY;
    public bool RotateByAxisZ;
    [Range(-1,1)]
    public float GravityScale;
    [Range(.1f, 2)]
    public float Speed; 
    public float CollideDamage;
    public float Health;
    
}
