using System;
using UnityEngine;

public class SpawnEnemySpawnerService : MonoSingletonGeneric<SpawnEnemySpawnerService>
{
    public SpawnEnemySpawnerData[] spawnEnemySpawnerData;
    [HideInInspector]
    protected override void Awake()
    {
        base.Awake();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnEnable()
    {
        SpawnEnemySpawner();
    }

    private void SpawnEnemySpawner()
    {
        for (int i = 0; i <spawnEnemySpawnerData.Length ; i++)
        {
            GameObject gmo = Instantiate(spawnEnemySpawnerData[i].EnemySpawnerGmo);
            gmo.transform.position = spawnEnemySpawnerData[i].SpawnLocation;
        }
    }
}
[Serializable]
public class SpawnEnemySpawnerData
{
    public Vector3 SpawnLocation;
    public GameObject EnemySpawnerGmo;
}
