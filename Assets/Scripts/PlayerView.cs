using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerModel playerModel;
    private GameObject playerPrefab;
    private PlayerController playerController;
    void Update()
    {
       playerController.ObjectBoundWithScreen();
       Debug.Log("uck");

       if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
       {
           playerController.Move();
       }

    }
    public void Init(PlayerController activeController)
        {
            this.playerController = activeController;
        }
   
}
