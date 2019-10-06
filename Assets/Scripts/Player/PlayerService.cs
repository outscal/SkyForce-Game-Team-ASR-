using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoSingletonGeneric<PlayerService>
{
    public PlayerScriptableObjectList playerScriptableObjectList;
    private PlayerView playerView;
    private PlayerController playerController;
    void Start()
    {
        playerView = playerScriptableObjectList.player[0].playerPrefab;
        PlayerModel model = new PlayerModel(playerScriptableObjectList.player[0]);
        playerController = new PlayerController(model,playerView);
    }
    void Update()
    {
        
    }
    public void SetPosition (Vector3 newPosition)
    {
        playerController.SetPosition(newPosition);
    }
}
