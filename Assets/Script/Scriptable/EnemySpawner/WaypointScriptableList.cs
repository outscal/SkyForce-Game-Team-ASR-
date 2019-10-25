using UnityEngine;

[CreateAssetMenu(fileName = "WaypointScriptable", menuName = "ScriptableObjects/WaypointScriptable/NewWaypointScriptableList")]
public class WaypointScriptableList : ScriptableObject
{
    public WaypointScriptable[] waypointScriptableArray;
}
