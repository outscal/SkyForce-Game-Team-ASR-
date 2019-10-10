using SkyForce.ObjectPool;
using System;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyService : MonoSingletonGeneric<EnemyService>
    {
        #region Variable Declaration

        public EnemyScriptablesList enemyScriptablesList;
        public EnemyView enemyView;
        [HideInInspector]
        public EnemyScriptables enemyScriptables;

        #endregion

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TestingEnemy();
            }
            
        }

        private void TestingEnemy()
        {
            EnemyModel enemyModel = GetEnemyModels(EnemyType.EnemyRotY3);
            EnemyController controller = EnemyObjectPooler.Instance.GetComponent<EnemyObjectPooler>().GetEnemyController(enemyView, enemyModel);
        }

        public EnemyController GetEnemyController(EnemyType enemyType)
        {
            EnemyModel enemyModel = GetEnemyModels(enemyType);
            EnemyController controller = EnemyObjectPooler.Instance.GetComponent<EnemyObjectPooler>().GetEnemyController(enemyView, enemyModel);
            return controller;
        }

        public EnemyModel GetEnemyModels(EnemyType type)
        {
            enemyScriptables = Array.Find(enemyScriptablesList.EnemyArray, x => x.Type.Equals(type));
            return new EnemyModel(enemyScriptables);
        }
    }
}

