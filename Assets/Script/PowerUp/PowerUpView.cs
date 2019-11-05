using SkyForce.Player;
using UnityEngine;

namespace SkyForce.Powerups
{
    public class PowerUpView : MonoBehaviour
    {
        private void Start()
        {
            Destroy(this, 1f);
        }
        PlayerModel ModelToSet;// used to set update player model on collide with power up
        public void SetModel(PlayerModel model)
        {
            ModelToSet = model;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            PlayerView playerView = null;
            playerView = collision.GetComponent<PlayerView>();
            if (playerView != null)
            {
                playerView.playerModel = ModelToSet;
                Destroy(this.gameObject);
            }
        }
    }
}

