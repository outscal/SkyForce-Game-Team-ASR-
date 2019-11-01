using UnityEngine;
using SkyForce.Interfaces;

namespace SkyForce.Bullet
{
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
            }
            else
            {
                Destroy(this.gameObject);
            }

        }

    }
}

