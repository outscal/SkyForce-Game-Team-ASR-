using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : MonoSingletonGeneric<BulletService>
{
   public BulletView bulletPrefab;
   public BulletController SpawnBullet(Vector3 BulletPosition){
       Debug.Log("BulletController Spawn");
       BulletModel model = new BulletModel(1,1);
       BulletController bulletController = new BulletController(model,bulletPrefab,BulletPosition);
       return bulletController;
       

   }
}
