using UnityEngine;

namespace SkyForce.Player
{
    public class PlayerService : MonoSingletonGeneric<PlayerService>
    {
        [SerializeField]
        public PlayerScriptableObjectList playerScriptableObjectList;

        [HideInInspector]
        [SerializeField]
        private PlayerView playerView;

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
       // playerView.transform.Translate(0f,4.5f * Time.deltaTime,0f);
      // playerController.PlayerView.transform.Translate(Vector3.up * 4.5f * Time.deltaTime);
       // transform.Translate(0f,4.5f * Time.deltaTime,0f);
       // playerController.SetPositionInScreen(this.transform.position.x,this.transform.position.y,this.transform.position.z);
       // playerController.Move();

    }
    public void SetPosition (float xPos,float yPos,float zPos)
    {
        playerController.SetPosition(xPos,yPos,zPos);
    }
    // public Vector3 ReturnPlayerPosition (){
    //    return playerController.ReturnPlayerPosition();
    // }
}
}

