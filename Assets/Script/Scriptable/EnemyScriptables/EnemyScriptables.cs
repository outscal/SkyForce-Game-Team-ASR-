using SkyForce.Enemy;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptables", menuName = "ScriptableObjects/EnemyScriptables/NewEnemyScriptableObject")]
[Serializable]
public class EnemyScriptables : ScriptableObject
{   
    [Header("Basic")]
    [Space(2)]
    public EnemyType Type;
    public EnemyView enemyView;
    public float CollideDamage;
    public float Health;
    [Header("Shooting Enemy")]
    [Space(2)]
    public bool IsShooting;
    [Header("ChangeMovement")]
    [Space(2)]
    public bool ChangeMovement;
    public bool MoveToLeftFirst;
    [Range(0,1)]
    public float LeftOffsetValue;
    [Range(0, 1)]
    public float RightOffsetValue;
    [Header("Size")]
    [Space(2)]
    public bool SizeIncreaseDecrease;
    [Space(2)]
    [Header("Rotate")]
    public bool IsRotating;
    public float RotateByAngleValue;
    public bool RotateByAxisY;
    public bool RotateByAxisZ;
    [Space(2)]
    [Range(-5,5)]
    public float GravityScale;
    [Header("Move Speed")]
    [Range(0, 2)]
    public float Speed; 
    
    
}
