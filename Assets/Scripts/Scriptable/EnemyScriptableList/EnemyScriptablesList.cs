using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableList",menuName = "ScriptableObjects/EnemyScriptables/NewEnemyScriptableObjectList")]
public class EnemyScriptablesList : ScriptableObject
{
    public EnemyScriptables[] Enemy;
}
