using UnityEngine;

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/Weapon", menuName = "ScriptableObjects/Weapon")]
public class WeaponScriptableObject : ScriptableObject
{
    public string WeaponName;
}

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/WeaponScriptableObjectList", menuName = "ScriptableObjects/Weapon Lists")]
public class WeaponScriptableObjectList : ScriptableObject
{
    public WeaponScriptableObject[] weapons;
}