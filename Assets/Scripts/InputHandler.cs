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
    public PlayerView playerView;
    private PlayerModel playerModel;
    public void ReadInput()
    {
        Vector2 TouchPosition = Input.GetTouch(0).deltaPosition;
        PlayerService.Instance.SetPosition(TouchPosition);
        // playerView.transform.Translate(TouchPosition.x * playerModel.Speed * Time.deltaTime, TouchPosition.y * playerModel.Speed * Time.deltaTime, 0);
        Debug.Log("Move");
    }
}
#endif
#if UNITY_EDITOR
public class InputHandler_Editor : IInput
{
    public PlayerView playerView;
    // private PlayerModel playerModel;
    // private PlayerController playerController;
    Vector3 target;
   
    public void ReadInput()
    {
        
        Debug.Log("step 2");
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0f;
        PlayerService.Instance.SetPosition(target);
       // playerView.transform.position = Vector3.MoveTowards(playerView.transform.position,target,playerModel.Speed*Time.deltaTime);

        
    }
}
#endif