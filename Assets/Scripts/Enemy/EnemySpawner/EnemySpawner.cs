using SkyForce.Enemy;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemySpawnScriptable enemySpawnScriptable;
    float timer = 0;
    private bool StartSpawn = false;
    CircleCollider2D circleCollider2D;
    int enemycount = 0;

    private void Awake()
    {
        circleCollider2D = GetComponent<CircleCollider2D>();
    }

    private void Start()
    {
        circleCollider2D.radius = enemySpawnScriptable.ColliderRadius;
        timer = enemySpawnScriptable.TimeBetweenSpawns;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<EnemyView>()!=null) 
        {
            Debug.LogError(" * Change getcomponent to identify the player When integrated * ");
            StartSpawn = true;
        }
    }

    private void Update()
    {
        if (StartSpawn)
        {
            if (timer > enemySpawnScriptable.TimeBetweenSpawns)
            {
                if(enemycount< enemySpawnScriptable.EnemyNumber)
                {
                    GetAllEnemy(enemySpawnScriptable.EnemyNoPerWave, enemySpawnScriptable.EnemyTypeToSpawn);
                    enemycount++;
                }
                else
                {
                    Destroy(this.gameObject,2);
                }
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
            }
            
        }
    }

    private void GetAllEnemy(float enemyNumberPerWave,EnemyType enemyType)
    {    
        for (int i = 0; i < enemyNumberPerWave; i++)
        {
            EnemyController enemyController = EnemyService.Instance.GetEnemyController(enemyType);
            enemyController.SetEnemyPos(transform.position);
        }
    }
}
