using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    public PlayerView playerView;
    private PlayerModel playerModel;
    private BulletController bulletController;
    private bool isLoaded;

    public PlayerController(PlayerModel playerModel, PlayerView playerView)
    {
        PlayerModel = playerModel;
        PlayerView = GameObject.Instantiate<PlayerView>(playerView,new Vector3 (-0.008988857f,3.59822f,0f),Quaternion.identity);
        // PlayerView = playerView;
        PlayerView.Init(this);
         isLoaded = true;
    }
    public PlayerModel PlayerModel { get; }
    public PlayerView PlayerView { get; }
    public void SetPosition(Vector3 newPosition)
    {
        PlayerView.SetPosition(newPosition);
    }
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
        if(isLoaded == true){
        Debug.Log("SpawnBullet");
        bulletController = BulletService.Instance.SpawnBullet(PlayerView.transform.position + new Vector3(0f, 1.7f, 0f));
        isLoaded = false;
        Reload();
    }
    }
    public async void Reload()
    {
        Debug.Log("Async Call");
        await new WaitForSeconds(0.4f);
        isLoaded = true;
        
    }


}
