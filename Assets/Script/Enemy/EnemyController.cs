using System;
using SkyForce.ObjectPool;
using SkyForce.Powerups;
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
                Vector3 enemypos = EnemyView.transform.position;
                InstantiatePowerUp(enemypos);                
                EnemyObjectPooler.Instance.ReturnItemToPool(this);
                explode = GameObject.Instantiate(EnemyView.explosion);
                explode.transform.position = enemypos;
                EnemyView.DestroyThisObject(explode, .5f);              
                EnemyView.PlayDeadAudio();
                EnemyView.gameObject.SetActive(false);
            }
        }

        private void InstantiatePowerUp(Vector3 pos)
        {
            int SpwanProbability = UnityEngine.Random.Range(0, 20);
            if (SpwanProbability == 1)
            {
                int powerupType = UnityEngine.Random.Range(1, 3);
                //PowerUpType pt = (PowerUpType)Enum.ToObject(typeof(PowerUpType), powerupType);
                PowerUpService.Instance.GetPowerUp((PowerUpType)powerupType, pos);
            }            
        }
    }
    
}

