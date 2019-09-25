﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyModel
    {
        public EnemyType Type;
        public bool IsShooting;
        public bool ChangeMovement;
        public float LeftOffsetValue;
        public float RightOffsetValue;
        public bool IsRotating;
        public float Speed;
        public float CollideDamage;
        public float Health;
        public bool MoveToLeftFirst;
        public float RotateByAngleValue;
        public float GravityScale;
        public bool RotateByAxisY;
        public bool RotateByAxisZ;
        public bool SizeIncreaseDecrease;

        public EnemyModel(EnemyScriptables enemyScriptables)
        {
            Type = enemyScriptables.Type;
            IsShooting = enemyScriptables.IsShooting;
            ChangeMovement = enemyScriptables.ChangeMovement;
            LeftOffsetValue = enemyScriptables.LeftOffsetValue;
            RightOffsetValue = enemyScriptables.RightOffsetValue;
            IsRotating = enemyScriptables.IsRotating;
            Speed = enemyScriptables.Speed;
            CollideDamage = enemyScriptables.CollideDamage;
            Health = enemyScriptables.Health;
            MoveToLeftFirst = enemyScriptables.MoveToLeftFirst;
            RotateByAngleValue = enemyScriptables.RotateByAngleValue;
            GravityScale = enemyScriptables.GravityScale;
            RotateByAxisY = enemyScriptables.RotateByAxisY;
            RotateByAxisZ = enemyScriptables.RotateByAxisZ;
            SizeIncreaseDecrease = enemyScriptables.SizeIncreaseDecrease;
        }
    }
}

