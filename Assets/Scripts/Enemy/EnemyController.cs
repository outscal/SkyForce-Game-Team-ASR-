using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyController
    {
        public EnemyView EnemyView { get; }
        public EnemyModel EnemyModel { get; }
        public EnemyController(EnemyView enemyView,EnemyModel enemyModel)
        {
            EnemyView = GameObject.Instantiate<EnemyView>(enemyView);
            EnemyModel = enemyModel;
            EnemyView.SetController(this);
        }

    }
    
}

