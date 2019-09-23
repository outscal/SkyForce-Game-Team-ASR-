using SkyForce.Interfaces;
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

        #endregion

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        #region call in controller functions 

        public void SetController(EnemyController controller)
        {
            enemyController = controller;
        }

        #endregion
    }


}
