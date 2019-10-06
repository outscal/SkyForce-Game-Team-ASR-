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
#elif UNITY_ANDROID
       controllerInput = new inputHandler_Android();
#endif
    }
    void Update()
    {
        // playerController.ObjectBoundWithScreen();
        Debug.Log("uck");
        // controllerInput.ReadInput();


        //    if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //    {
        //        playerController.Move_Android();
        //    }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Step 1");
            controllerInput.ReadInput();
            Debug.Log("Step 4");
        }


        //    playerController.Move_Editor();

    }
    public void Init(PlayerController activeController)
    {
        this.playerController = activeController;
    }
    public void SetPosition(Vector3 newPosition){
        transform.position = newPosition;
    }

}
