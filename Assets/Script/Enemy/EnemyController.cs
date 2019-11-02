using SkyForce.ObjectPool;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyController
    {
        public EnemyView EnemyView { get; }
        public EnemyModel EnemyModel { get; set;}
        private Vector3 SpawnPos;
        GameObject explode;
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
                //play a destroy particle effect or anim
                //EnemyView.OnDeath();
                EventServices.InitializeKillCounter();
                EnemyObjectPooler.Instance.ReturnItemToPool(this);
                explode = GameObject.Instantiate(EnemyView.explosion);
                explode.transform.position = EnemyView.transform.position;
                EnemyView.DestroyThisObject(explode, .5f);
                EnemyView.PlayDeadAudio();
                EnemyView.gameObject.SetActive(false);
            }
        }
    }
    
}

