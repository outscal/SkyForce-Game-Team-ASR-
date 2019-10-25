using UnityEngine;

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/Tile", menuName = "ScriptableObjects/Tile")]
public class TileScriptableObject : ScriptableObject
{
    public string TileName;
}

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/TileScriptableObjectList", menuName = "ScriptableObjects/Tile Lists")]
public class TileScriptableObjectList : ScriptableObject
{
    public TileScriptableObject[] tiles;
}