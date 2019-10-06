using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySpawnScriptable",menuName = "ScriptableObjects/EnemySpawnScriptable/NewEnemySpawnScriptable")]
public class EnemySpawnScriptable : ScriptableObject
{
    public EnemyType EnemyTypeToSpawn;
    public WaypointType WaypointToMove;
    public float EnemyNumber;
    public float TimeBetweenSpawns;
}
