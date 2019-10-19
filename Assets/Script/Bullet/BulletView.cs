using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Interfaces;

public class BulletView : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, 1 * Time.deltaTime, 0);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        IDamagable damagable = other.gameObject.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.TakeDamage(50f);
            Debug.Log("Collide");
            //Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    
}
