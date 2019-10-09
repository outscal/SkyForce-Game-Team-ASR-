using System.Collections;
using System.Collections.Generic;
using UnityEngine;
interface IInput
{
    void ReadInput();
}
#if UNITY_ANDROID
public class InputHandler_Android : IInput
{

    public void ReadInput()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
        Vector2 TouchPosition = Input.GetTouch(0).deltaPosition;
        PlayerService.Instance.SetPosition(TouchPosition);
        Debug.Log("Player Service");

        }
    }

#endif
#if UNITY_EDITOR
public class InputHandler_Editor : IInput
{
    Vector3 target;
   
    public void ReadInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0f;
        PlayerService.Instance.SetPosition(target);
        Debug.Log("Player Service");
        }
        
    }
}
#endif