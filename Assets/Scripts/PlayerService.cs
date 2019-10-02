using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoBehaviour
{
    public PlayerScriptableObjectList playerScriptableObjectList;
    private PlayerView playerView;
    void Start()
    {
        playerView = playerScriptableObjectList.player[0].playerPrefab;
        PlayerModel model = new PlayerModel(playerScriptableObjectList.player[0]);
        PlayerController playerController = new PlayerController(model,playerView);
    }
    void Update()
    {
        
    }
}
