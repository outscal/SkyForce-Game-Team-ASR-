using SkyForce.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyView : MonoBehaviour,IDamagable
    {
        #region Interface Imlementation

        public void TakeDamage()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Declaration of variables

        private EnemyController enemyController;
        Rigidbody2D rgbd2D;
        Vector3 axisOfRoatation;

        #endregion

        // Start is called before the first frame update
        void Start()
        {
            rgbd2D = GetComponent<Rigidbody2D>();
            rgbd2D.gravityScale = enemyController.EnemyModelC.GravityScale;
            if (enemyController.EnemyModelC.IsRotating)
            {
                SetRotationAxis();
            }   
        }

        private void SetRotationAxis()
        {
            if (enemyController.EnemyModelC.RotateByAxisY)
            {
                axisOfRoatation = Vector3.up;
            }
            if (enemyController.EnemyModelC.RotateByAxisZ)
            {
                axisOfRoatation = Vector3.forward;
            }
            if (enemyController.EnemyModelC.RotateByAxisY && enemyController.EnemyModelC.RotateByAxisZ)
            {
                axisOfRoatation = new Vector3(0, 1, 1);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if(enemyController.EnemyModelC != null)
            {
                MoveEnemy();
                RotateEnemy();
            }
            
        }

        #region move enemy functions
        private void MoveEnemy()
        {
            if (enemyController.EnemyModelC.ChangeMovement)
            {
                Vector2 moveToPos = SetMovementPos();
                rgbd2D.MovePosition(moveToPos);
                //rgbd2D.MovePosition(moveToPos * Time.deltaTime); crazy behaviour 

            }
            else
            {
                Vector2 moveToPos = new Vector2(transform.position.x, transform.position.y) - new Vector2(0, enemyController.EnemyModelC.Speed);
                rgbd2D.MovePosition(moveToPos);
            }
        }

        private Vector2 SetMovementPos()
        {
            if (enemyController.EnemyModelC.MoveToLeftFirst)
            {
                enemyController.EnemyModelC.MoveToLeftFirst = false;
                return new Vector2(transform.position.x, transform.position.y) - new Vector2(enemyController.EnemyModelC.LeftOffsetValue, enemyController.EnemyModelC.Speed);
            }
            else
            {
                enemyController.EnemyModelC.MoveToLeftFirst = true;
                return new Vector2(transform.position.x, transform.position.y) + new Vector2(enemyController.EnemyModelC.RightOffsetValue, enemyController.EnemyModelC.Speed);
            }
            
        }

        private void RotateEnemy()
        {
            transform.Rotate(axisOfRoatation,enemyController.EnemyModelC.RotateByAngleValue);
        }
        #endregion

        #region call in controller functions 

        public void SetController(EnemyController controller)
        {
            enemyController = controller;
        }

        #endregion
    }


}
