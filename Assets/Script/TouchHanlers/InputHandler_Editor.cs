using SkyForce.Player;
using UnityEngine;


#if UNITY_EDITOR
public class InputHandler_Editor : IInput
{
    Vector3 target;
    public void ReadInput()
    {
      
      //target = PlayerService.Instance.SetPositionInScreen();
        if(Input.GetMouseButton(0)){
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0f;
        PlayerService.Instance.SetPosition(target.x, target.y, target.z);
        Debug.Log("Player Service");
        }
        else
        {
         
          target.y = target.y + 4.5f*Time.deltaTime;
          target.z = 0f;
           PlayerService.Instance.SetPosition(target.x,target.y,target.z);
        }
}
}
#endif