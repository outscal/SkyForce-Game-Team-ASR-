using SkyForce.Interfaces;
using SkyForce.Player;
using UnityEngine;

namespace SkyForce.Powerups
{
    public class PowerUpView : MonoBehaviour,ICollectable
    {

        PlayerModel ModelToSet;// used to set update player model on collide with power up
        public void SetModel(PlayerModel model)
        {
            ModelToSet = model;
        }

        //private void OnTriggerEnter2D(Collider2D collision)
        //{
        //    PlayerView playerView = null;
        //    playerView = collision.GetComponent<PlayerView>();
        //    if (playerView != null)
        //    {
        //        playerView.playerModel = ModelToSet;
        //        Destroy(this.gameObject);
        //    }
        //}

        public void OnCollect(GameObject CollectedByGameobject)
        {
            if (CollectedByGameobject.GetComponent<PlayerView>()!=null)
            {
                CollectedByGameobject.GetComponent<PlayerView>().playerModel = ModelToSet;
                Destroy(this.gameObject);
            }
            
        }
    }
}

