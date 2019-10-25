using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : MonoSingletonGeneric<BulletService>
{
    public BulletScriptableObjectList bulletScriptableObjectList;
    private BulletView bulletPrefab;
    [HideInInspector]
    public float bulletSpeed;
     [HideInInspector]
    public float bulletDamage;

   public BulletController SpawnBullet(Vector3 BulletPosition){
       Debug.Log("BulletController Spawn");
       bulletPrefab = bulletScriptableObjectList.bulletList[0].bulletPrefab;
       bulletSpeed = bulletScriptableObjectList.bulletList[0].BulletSpeed;
       bulletDamage = bulletScriptableObjectList.bulletList[0].Damage;
       BulletModel model = new BulletModel(bulletScriptableObjectList.bulletList[0]);
       BulletController bulletController = new BulletController(model,bulletPrefab,BulletPosition);
       return bulletController;
       

   }
}
