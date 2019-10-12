using SkyForce.ObjectPool;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyController
    {
        public EnemyView EnemyView { get; }
        public EnemyModel EnemyModel { get; set;}
        private Vector3 SpawnPos;
        public EnemyController(EnemyView enemyView,EnemyModel enemyModel)
        {
            EnemyView = GameObject.Instantiate<EnemyView>(enemyView);
            EnemyModel = enemyModel;
            SpawnPos = EnemyView.transform.position;
            EnemyView.SetController(this);
        }
        public void ResetModel()
        {
            EnemyModel Default = new EnemyModel(EnemyService.Instance.enemyScriptables);
            EnemyModel = Default;
        }
        public void ResetPosition()
        {
            EnemyView.transform.position = SpawnPos;
        }
        public void SetEnemyPos(Vector3 SetPosition)
        {
            EnemyView.transform.position = SetPosition;
        }
        public void ApplyDamage(float damage)
        {
            if(EnemyModel.Health - damage > 0)
            {
                EnemyModel.Health -= damage;
            }
            else
            {
                //play a destroy particle effect
                EnemyObjectPooler.Instance.ReturnItemToPool(this);
            }
        }
    }
    
}

