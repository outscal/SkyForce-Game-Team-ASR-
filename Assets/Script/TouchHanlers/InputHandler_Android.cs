using System.Collections;
using System.Collections.Generic;
using UnityEngine;


#if UNITY_ANDROID
public class InputHandler_Android : IInput
{

     public void ReadInput()
    {
        Vector3 target;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0f;
        PlayerService.Instance.SetPosition(target.x, target.y + 1.5f, target.z);
        Debug.Log("Player Service");
}
}

#endif
