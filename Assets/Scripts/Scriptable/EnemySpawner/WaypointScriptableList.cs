using UnityEngine;

[CreateAssetMenu(fileName = "WaypointScriptable", menuName = "ScriptableObjects/WaypointScriptable/NewWaypointScriptable")]
public class WaypointScriptableList : ScriptableObject
{
    public WaypointScriptable[] waypointScriptableArray;
}
