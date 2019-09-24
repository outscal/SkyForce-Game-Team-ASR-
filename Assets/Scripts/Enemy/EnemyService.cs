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

        public EnemyController GetEnemyController(EnemyType enemyType)
        {
            return null;
        }

        public EnemyModel SetModels(EnemyType type)
        {
            if(type == EnemyType.Enemytype0)
            {
                return new EnemyModel(enemyScriptablesList.Enemy[0]);
            }
            return null;
        }
    }
}

