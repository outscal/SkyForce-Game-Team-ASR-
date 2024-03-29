﻿using UnityEngine;
using SkyForce.Interfaces;

namespace SkyForce.Player
{
    public class PlayerView : MonoBehaviour, IDamagable
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            ICollectable collectobj = collision.gameObject.GetComponent<ICollectable>();
            if(collectobj != null)
            {
                collectobj.OnCollect(gameObject);
            }
        }
        [HideInInspector]
        public PlayerModel playerModel;

        private GameObject playerPrefab;
        [SerializeField]

        private PlayerController playerController;
        [SerializeField]

        private IInput controllerInput;
        void Start()
        {
#if UNITY_EDITOR
            controllerInput = new InputHandler_Editor();

#elif UNITY_ANDROID
       controllerInput = new InputHandler_Android();
#endif
    }
    void Update()
    {
        playerController.ObjectBoundWithScreen();

        controllerInput.ReadInput();
        playerController.GetBullet();
        //transform.Translate(0,10,0);
      //  transform.Translate(Vector3.up*4.5f*Time.deltaTime);
      
        

    }
    public void TakeDamage(float damage)
    {
        playerController.ApplyDamage(damage);
       
    }

    public void Init(PlayerController activeController)
    {
        this.playerController = activeController;
    }
    public void SetPosition(float xPos,float yPos,float zPos)
    {
        transform.position = new Vector3(xPos,yPos,zPos);
    }
    public void OnDeath()
    {
        Destroy(this.gameObject);
    }
    // public void SetPositionInScreen(){
    //     transform.position = new Vector3(0,10f * Time.deltaTime,0);
    // }
    // public Vector3 ReturnPosition(){
    // return transform.position;
    // }




}
}
