using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyController
    {
        public EnemyView EnemyViewC { get; }
        public EnemyModel EnemyModelC { get; }

        public EnemyController(EnemyView enemyView,EnemyModel enemyModel)
        {
            EnemyViewC = GameObject.Instantiate<EnemyView>(enemyView);
            EnemyModelC = enemyModel;
            EnemyViewC.SetController(this);
        }

       
    }

}

