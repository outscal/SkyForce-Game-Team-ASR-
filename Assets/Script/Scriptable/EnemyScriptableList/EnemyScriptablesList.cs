﻿using System;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableList",menuName = "ScriptableObjects/EnemyScriptables/NewEnemyScriptableObjectList")]
[Serializable]
public class EnemyScriptablesList : ScriptableObject
{
    public EnemyScriptables[] EnemyArray;
}
