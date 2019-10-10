using UnityEngine;
[CreateAssetMenu(fileName = "WaypointScriptable", menuName = "ScriptableObjects/WaypointScriptable/NewWaypointScriptable")]
public class WaypointScriptable : ScriptableObject
{
    public WaypointType WayType;
    public GameObject[] GameObjectsPos;
}
