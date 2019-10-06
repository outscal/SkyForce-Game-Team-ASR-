using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    public PlayerView playerView;
    private PlayerModel playerModel;
    private BulletController bulletController;

    public PlayerController(PlayerModel playerModel, PlayerView playerView)
    {
        PlayerModel = playerModel;
        PlayerView = GameObject.Instantiate<PlayerView>(playerView);
        // PlayerView = playerView;
        PlayerView.Init(this);
    }
    public PlayerModel PlayerModel { get; }
    public PlayerView PlayerView { get; }
    public void SetPosition(Vector3 newPosition)
    {
        PlayerView.SetPosition(newPosition);
    }

    // public void Move_Android()
    // {
    //     Vector2 TouchPosition = Input.GetTouch(0).deltaPosition;
    //     PlayerView.transform.Translate(TouchPosition.x * playerModel.Speed * Time.deltaTime, TouchPosition.y * playerModel.Speed * Time.deltaTime, 0);
    //     Debug.Log("Move");
    // }
    // public void Move_Editor(){
    //     Debug.Log("moving in editor");
    // }
    public void ObjectBoundWithScreen()
    {
        Debug.Log("Call");
        PlayerView.transform.position = new Vector3(Mathf.Clamp(PlayerView.transform.position.x, -2.3f, 2.3f),
                                 Mathf.Clamp(PlayerView.transform.position.y, -4.2f, 4.2f),
                                 PlayerView.transform.position.z);
        Debug.Log("Bound");
    }
    public void GetBullet()
    {
        Debug.Log("SpawnBullet");
        bulletController = BulletService.Instance.SpawnBullet( PlayerView.transform.position + new Vector3(0f,1.7f,0f));
    }
}
