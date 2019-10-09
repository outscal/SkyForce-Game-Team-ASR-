using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerModel playerModel;
    private GameObject playerPrefab;
    private PlayerController playerController;
    private IInput controllerInput;
    void Start()
    {
#if UNITY_EDITOR
        controllerInput = new InputHandler_Editor();
#endif
#if UNITY_ANDROID
       controllerInput = new InputHandler_Android();
#endif
    }
    void Update()
    {
        
        Debug.Log("Duck");
        controllerInput.ReadInput();
        playerController.GetBullet(); 
        
        
    }
   
    public void Init(PlayerController activeController)
    {
        this.playerController = activeController;
    }
    public void SetPosition(Vector3 newPosition)
    {
        transform.position = newPosition;
    }
    
    

}
