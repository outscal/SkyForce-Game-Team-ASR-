using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyService : MonoSingletonGeneric<EnemyService>
    {
        #region Variable Declaration

        public EnemyScriptablesList enemyScriptablesList;
        public EnemyView enemyView;

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
            EnemyModel enemyModel = SetModels(EnemyType.Enemytype2);
            EnemyController controller = new EnemyController(enemyView, enemyModel);
        }

        public EnemyController GetEnemyController(EnemyType enemyType)
        {
            EnemyModel enemyModel = SetModels(enemyType);
            EnemyController controller = new EnemyController(enemyView, enemyModel);
            return controller;
        }

        public EnemyModel SetModels(EnemyType type)
        {
            //if (type == EnemyType.Enemytype0)
            //{
            //    return new EnemyModel(enemyScriptablesList.Enemy[0]);
            //}
            //EnemyScriptables enemy1 = Array.Find(enemyScriptablesList, x => x.Enemy.Type == type);
            EnemyScriptables enemy = Array.Find(enemyScriptablesList.Enemy, x => x.Type.Equals(type));
            return new EnemyModel(enemy);
        }
    }
}

