using SkyForce.Bullet;
using UnityEngine;

namespace SkyForce.Player
{
    public class PlayerController
    {
        [SerializeField]

        public PlayerView playerView;
        [SerializeField]

        private PlayerModel playerModel;
        [SerializeField]

        private BulletController bulletController;
        private bool isLoaded;
        private float initialHealth;

<<<<<<< HEAD
        public PlayerController(PlayerModel playerModel, PlayerView playerView)
=======
    public PlayerController(PlayerModel playerModel, PlayerView playerView)
    {
        PlayerModel = playerModel;
        PlayerView = GameObject.Instantiate<PlayerView>(playerView, new Vector3(-0.008988857f, 3.59822f, 0f), Quaternion.identity);
        // PlayerView = playerView;
        PlayerView.Init(this);
        isLoaded = true;
        initialHealth = PlayerModel.Health;
    }
    public PlayerModel PlayerModel { get; }
    public PlayerView PlayerView { get; }
    public void SetPosition(float xPos,float yPos,float zPos)
    {
        PlayerView.SetPosition(xPos,yPos,zPos);
    }
    public void ObjectBoundWithScreen()
    {
        Debug.Log("Call");
        PlayerView.transform.position = new Vector3(Mathf.Clamp(PlayerView.transform.position.x, -3.06f, 3.06f),
                                 Mathf.Clamp(PlayerView.transform.position.y, -5.5f, 5.5f),
                                 PlayerView.transform.position.z);
        Debug.Log("Bound");
    }
    public void GetBullet()
    {
        if (isLoaded == true)
>>>>>>> MainMenu
        {
            PlayerModel = playerModel;
            PlayerView = GameObject.Instantiate<PlayerView>(playerView, new Vector3(-0.008988857f, 3.59822f, 0f), Quaternion.identity);
            // PlayerView = playerView;
            PlayerView.Init(this);
            isLoaded = true;
            initialHealth = PlayerModel.Health;
        }
        public PlayerModel PlayerModel { get; }
        public PlayerView PlayerView { get; }
        public void SetPosition(float xPos, float yPos, float zPos)
        {
            PlayerView.SetPosition(xPos, yPos, zPos);
        }
        public void ObjectBoundWithScreen()
        {
            Debug.Log("Call");
            PlayerView.transform.position = new Vector3(Mathf.Clamp(PlayerView.transform.position.x, -3.06f, 3.06f),
                                     Mathf.Clamp(PlayerView.transform.position.y, -6.18f, 6.18f),
                                     PlayerView.transform.position.z);
            Debug.Log("Bound");
        }
        public void GetBullet()
        {
            if (isLoaded == true)
            {
                Debug.Log("SpawnBullet");
                bulletController = BulletService.Instance.SpawnBullet(PlayerView.transform.position + new Vector3(0f, 0.5f, 0f));
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
        public void ApplyDamage(float damage)
        {

            if (PlayerModel.Health > 0)
            {
                PlayerModel.Health -= damage;



            }
            else
            {
                PlayerView.OnDeath();
                //UIService.Instance.HealthBarUpdate(damage/PlayerModel.Health);
                // 1f means death
            }
            UIService.Instance.HealthBarUpdate((1 - (PlayerModel.Health / initialHealth)));



        }

<<<<<<< HEAD
=======
    }
    // public void Move(){
    //     PlayerView.transform.Translate(Vector3.up * 4.5f * Time.deltaTime);
    // }
    // public Vector3 ReturnPlayerPosition(){
    //  return PlayerView.ReturnPosition();
    // }
>>>>>>> MainMenu

    }

}

