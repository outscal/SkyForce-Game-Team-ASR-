using UnityEngine;
namespace SkyForce.Bullet
{
    public class BulletController
    {
        public float speed;
        public BulletController(BulletModel model, BulletView bulletPrefab, Vector3 position)
        {
            BulletModel = model;
            BulletView = GameObject.Instantiate<BulletView>(bulletPrefab, position, Quaternion.identity);
            speed = model.BulletSpeed;
        }
        public BulletModel BulletModel { get; }
        public BulletView BulletView { get; }
    }
}

