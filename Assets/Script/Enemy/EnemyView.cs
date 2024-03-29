﻿using SkyForce.Bullet;
using SkyForce.Interfaces;
using SkyForce.ObjectPool;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyView : MonoBehaviour, IDamagable
    {
        // private void OnTriggerEnter2D(Collider2D collision)
        // {
        //     IDamagable Collobj = collision.GetComponent<IDamagable>();
        //     if (Collobj != null)
        //     {
        //         Collobj.TakeDamage(enemyController.EnemyModel.CollideDamage);
        //     }
        // }

        #region Declaration of variables
            [HideInInspector]
        public EnemyController enemyController;
        Rigidbody2D rgbd2D;
        Vector3 axisOfRoatation;
        float timer = 0;
        public GameObject explosion;
        AudioSource audioSource;


        //private EnemyModel Defaultmodel;
        #endregion

        public void TakeDamage(float damage)
        {
            enemyController.ApplyDamage(damage);
        }
        public void DestroyThisObject(GameObject gmo , float time)
        {
            Destroy(gmo, time);
        }
        public void PlayDeadAudio()
        {
            audioSource.Play();
        }
        // Start is called before the first frame update
        void Start()
        {
            //Defaultmodel = enemyController.EnemyModel;
            rgbd2D = gameObject.GetComponent<Rigidbody2D>();
            audioSource = gameObject.GetComponent<AudioSource>();
            rgbd2D.gravityScale = enemyController.EnemyModel.GravityScale;
            if (enemyController.EnemyModel.IsRotating)
            {
                SetRotationAxis();// convert to accept values  & make it virtual 
            }
        }

        private void SetRotationAxis()
        {
            if (enemyController.EnemyModel.RotateByAxisY)
            {
                axisOfRoatation = Vector3.up;
            }
            if (enemyController.EnemyModel.RotateByAxisZ)
            {
                axisOfRoatation = Vector3.forward;
            }
            if (enemyController.EnemyModel.RotateByAxisY && enemyController.EnemyModel.RotateByAxisZ)
            {
                axisOfRoatation = new Vector3(0, 1, 1);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (enemyController.EnemyModel != null)
            {
                MoveEnemy();
                RotateEnemy();
            }
            //Pool Test Code
            if (timer > 3)
            {
                EnemyObjectPooler.Instance.ReturnItemToPool(this.enemyController);
                gameObject.SetActive(false);
                timer = 0;

            }
            else
            {
                timer += Time.deltaTime;
            }
            if (enemyController.EnemyModel.IsShooting)
            {
                BulletController bulletController = BulletService.Instance.SpawnBullet(transform.position);
            }

        }

        #region move enemy functions
        private void MoveEnemy()
        {
            if (enemyController.EnemyModel.ChangeMovement)
            {
                Vector2 moveToPos = SetMovementPos();
                rgbd2D.MovePosition(moveToPos);
                //rgbd2D.MovePosition(moveToPos * Time.deltaTime); crazy behaviour 

            }
            else
            {
                Vector2 moveToPos = new Vector2(transform.position.x, transform.position.y) - new Vector2(0, enemyController.EnemyModel.Speed);
                rgbd2D.MovePosition(moveToPos);
            }
        }

        private Vector2 SetMovementPos()
        {
            if (enemyController.EnemyModel.MoveToLeftFirst)
            {
                enemyController.EnemyModel.MoveToLeftFirst = false;
                return new Vector2(transform.position.x, transform.position.y) - new Vector2(enemyController.EnemyModel.LeftOffsetValue, enemyController.EnemyModel.Speed);
            }
            else
            {
                enemyController.EnemyModel.MoveToLeftFirst = true;
                return new Vector2(transform.position.x, transform.position.y) + new Vector2(enemyController.EnemyModel.RightOffsetValue, enemyController.EnemyModel.Speed);
            }

        }

        private void RotateEnemy()
        {
            transform.Rotate(axisOfRoatation, enemyController.EnemyModel.RotateByAngleValue);
        }
        #endregion

        #region call in controller functions 

        public void SetController(EnemyController controller)
        {
            enemyController = controller;
        }

        #endregion

        public void OnDeath()
        {
            Destroy(this.gameObject);
        }
        void OnTriggerEnter2D(Collider2D  other)
        {
            IDamagable damagable = other.gameObject.GetComponent<IDamagable>();
            if (damagable != null)
            {
                damagable.TakeDamage(enemyController.EnemyModel.CollideDamage);
               //  Destroy(other.gameObject);
                 //Destroy(this.gameObject);
            }
        }

    }

}
