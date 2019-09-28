using SkyForce.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.ObjectPool
{
    public class EnemyObjectPooler : GenericPooler<EnemyController>
    {
        private EnemyView EnemyView { get; set; }
        private EnemyModel EnemyModel { get; set; }

        public EnemyController GetEnemyController(EnemyView enemyView, EnemyModel enemyModel)
        {
            this.EnemyView = enemyView;
            this.EnemyModel = enemyModel;
            EnemyController enemyController =  GetPooledItem();
            enemyController.EnemyView.gameObject.SetActive(true);
            return enemyController;
        }

        public override EnemyController CreateItem()
        {
            EnemyController enemy = new EnemyController(EnemyView, EnemyModel);
            return enemy;
        }
    }
}

