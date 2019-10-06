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
