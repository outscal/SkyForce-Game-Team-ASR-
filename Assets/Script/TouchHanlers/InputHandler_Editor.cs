using SkyForce.Player;
using UnityEngine;


#if UNITY_EDITOR
public class InputHandler_Editor : IInput
{
    Vector3 target;
    public void ReadInput()
    {
        if (Input.GetMouseButton(0))
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0f;
        PlayerService.Instance.SetPosition(target.x, target.y + 1.5f, target.z);
        Debug.Log("Player Service");
    }
 
}
#endif