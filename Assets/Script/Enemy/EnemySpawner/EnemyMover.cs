using SkyForce.Enemy;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.SpawnEnemy
{
    public class EnemyMover : MonoBehaviour
    {
        public EnemySpawnScriptable enemySpawnScriptable;
        public WaypointScriptableList waypointScriptableList;
        [HideInInspector]
        public WaypointScriptable WaypointScriptable;
        private List<EnemyController> enemyControllerList;
        float timer = 0;
        private void Start()
        {
            //GetWaypointScriptable(enemySpawnScriptable.WaypointType);
        }
        private void Update()
        {
            if (timer > enemySpawnScriptable.TimeBetweenSpawns)
            {
                GetAllEnemy(enemySpawnScriptable.EnemyNumber, enemySpawnScriptable.EnemyTypeToSpawn);
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
            }

        }

        public void GetWaypointScriptable(WaypointType type)
        {
            WaypointScriptable = Array.Find(waypointScriptableList.waypointScriptableArray, x => x.WayType.Equals(type));
        }

        private void GetAllEnemy(float enemyNumber, EnemyType enemyType)
        {
            for (int i = 0; i < enemyNumber; i++)
            {
                EnemyController enemyController = EnemyService.Instance.GetEnemyController(enemyType);
                enemyController.SetEnemyPos(WaypointScriptable.GameObjectsPos[0].transform.position);
                enemyControllerList.Add(enemyController);
                MoveOnWayPoint(enemyController);
                //move enemy from one point to other            
            }
        }

        private void MoveOnWayPoint(EnemyController enemyController)
        {
            for (int j = 0; j < WaypointScriptable.GameObjectsPos.Length - 1; j++)
            {
                transform.position = Vector2.MoveTowards(enemyController.EnemyView.transform.position, WaypointScriptable.GameObjectsPos[j].transform.position, enemyControllerList[j].EnemyModel.Speed * Time.deltaTime);
            }
        }
    }

}


