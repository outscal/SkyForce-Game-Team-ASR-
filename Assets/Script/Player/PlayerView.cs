using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Interfaces;

public class PlayerView : MonoBehaviour, IDamagable
{
    [SerializeField]
    private PlayerModel playerModel;

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
        Debug.Log("Duck");
        controllerInput.ReadInput();
        playerController.GetBullet();

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




}
