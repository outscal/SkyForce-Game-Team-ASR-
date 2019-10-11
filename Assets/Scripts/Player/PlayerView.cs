using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField]
    private PlayerModel playerModel;

    private GameObject playerPrefab;
    [SerializeField]

    private PlayerController playerController;
    [SerializeField]

    private IInput controllerInput;
    void Start()
    {
#if UNITY_EDITOR
        controllerInput = new InputHandler_Editor();

#elif UNITY_ANDROID
       controllerInput = new InputHandler_Android();
#endif
    }
    void Update()
    {
        //playerController.ObjectBoundWithScreen();
        Debug.Log("Duck");
        controllerInput.ReadInput();
        playerController.GetBullet();


    }

    public void Init(PlayerController activeController)
    {
        this.playerController = activeController;
    }
    public void SetPosition(float xPos,float yPos,float zPos)
    {
        transform.Translate(xPos,yPos,zPos);
    }



}
