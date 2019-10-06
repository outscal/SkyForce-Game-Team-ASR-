using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController
{
    public BulletController(BulletModel model, BulletView bulletPrefab){
        BulletModel = model;
        BulletView = bulletPrefab;

    }
    public BulletModel BulletModel { get;}
    public BulletView BulletView { get;}
}
