using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySpawnScriptable",menuName = "ScriptableObjects/EnemySpawnScriptable/NewEnemySpawnScriptable")]
public class EnemySpawnScriptable : ScriptableObject
{
    public EnemyType EnemyTypeToSpawn;
    public int EnemyNumber;
    [Min(1)]
    public int EnemyNoPerWave;
    public float TimeBetweenSpawns;
    public float ColliderRadius;
}
