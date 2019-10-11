using System.Collections;
using System.Collections.Generic;
using UnityEngine;


#if UNITY_ANDROID
public class InputHandler_Android : IInput
{

    public void ReadInput()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 TouchPosition = Input.GetTouch(0).deltaPosition;
            PlayerService.Instance.SetPosition(TouchPosition.x*10*Time.deltaTime,TouchPosition.y*10*Time.deltaTime,0f);
            Debug.Log("Player Service");

        }
    }
}

#endif
