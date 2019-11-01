using SkyForce.Player;
using UnityEngine;


#if UNITY_ANDROID
public class InputHandler_Android : IInput
{
<<<<<<< HEAD
    public void ReadInput()
=======
Vector3 target;
     public void ReadInput()
>>>>>>> MainMenu
    {
       //target = PlayerService.Instance.SetPositionInScreen();
        if(Input.GetMouseButton(0)){
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0f;
        PlayerService.Instance.SetPosition(target.x, target.y, target.z);
        Debug.Log("Player Service");
<<<<<<< HEAD

    }
=======
        }
        else
        {
          // target = Camera.main.ScreenToWorldPoint()
         // target.x = target.x;
          target.y = target.y + 4.5f*Time.deltaTime;
          target.z = 0f;
           PlayerService.Instance.SetPosition(target.x,target.y,target.z);
        }
}
>>>>>>> MainMenu
}

#endif
