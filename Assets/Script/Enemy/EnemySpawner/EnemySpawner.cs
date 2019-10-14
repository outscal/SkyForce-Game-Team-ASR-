using SkyForce.Enemy;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemySpawnScriptable enemySpawnScriptable;
    public bool DisplaceTargetTweenPos = false; //Only use this if gmo holding this script at 0,0,0 as the tween target is set per spawner pos and diplaced as per it 
    [Header("Tween Parameters")]
    public bool UseTween = true;
    public Vector3 TweenToPos;
    public float TweenTimeValue;
    public iTween.EaseType easeType;
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
        if(collision.GetComponent<PlayerView>()!=null) 
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
            if (UseTween)
            {
                GameObject enemyGmo = enemyController.EnemyView.gameObject;
                Vector3 Tweenpos = TweenToPos;
                if (DisplaceTargetTweenPos)
                {
                    Tweenpos += enemyGmo.transform.position;
                }
                iTween.MoveTo(enemyGmo, iTween.Hash("position",Tweenpos, "Time",TweenTimeValue,"easetype",easeType));
            }
        }
    }
}
