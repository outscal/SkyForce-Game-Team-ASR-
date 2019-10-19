using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerScriptableObjectsList",menuName = "ScriptableObjects/Player/NewPlayerScriptableObjectList")]
public class PlayerScriptableObjectList : ScriptableObject
{
[SerializeField]
public PlayerScriptableObject[] player;
}

