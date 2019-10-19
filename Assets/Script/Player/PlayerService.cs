using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoSingletonGeneric<PlayerService>
{
    [SerializeField]
    public PlayerScriptableObjectList playerScriptableObjectList;

    [HideInInspector]
    [SerializeField]
    public PlayerView playerView;

    [SerializeField]
    private PlayerController playerController;
    void Start()
    {
       // GameObject.Instantiate<PlayerView>(playerView,new Vector3 (-1f,3.59822f,0f),Quaternion.identity);
        playerView = playerScriptableObjectList.player[0].playerPrefab;
        PlayerModel model = new PlayerModel(playerScriptableObjectList.player[0]);
        playerController = new PlayerController(model,playerView);
        
    }
    void Update()
    {
        
    }
    public void SetPosition (float xPos,float yPos,float zPos)
    {
        playerController.SetPosition(xPos,yPos,zPos);
    }
}
