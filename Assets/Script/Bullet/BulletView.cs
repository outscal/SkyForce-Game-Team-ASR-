using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Interfaces;
using SkyForce.ObjectPool;
using SkyForce.Enemy;

public class BulletView : MonoBehaviour
{
    private BulletModel bulletModel;
    private float speed;
    void Start()
    {
        speed = BulletService.Instance.bulletSpeed;
    }
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
    // void OnCollisionEnter2D(Collision2D other)
    // {
    //     IDamagable damagable = other.gameObject.GetComponent<IDamagable>();
    //     if (damagable != null)
    //     {
    //         damagable.TakeDamage(/*bulletModel.BulletDamage*/50f);
    //     }
    //     else
    //     {
    //         Destroy(this.gameObject);
    //     }
    // }
    void OnTriggerEnter2D(Collider2D other)
    {
        IDamagable damagable = other.gameObject.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.TakeDamage(/*bulletModel.BulletDamage*/50f);
            Debug.Log("bulletcollide");
               }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

}
