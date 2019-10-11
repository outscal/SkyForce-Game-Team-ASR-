using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController
{
    public BulletController(BulletModel model, BulletView bulletPrefab, Vector3 position){
        BulletModel = model;
        BulletView = GameObject.Instantiate<BulletView>(bulletPrefab,position,Quaternion.identity);

    }
    public BulletModel BulletModel { get;}
    public BulletView BulletView { get;}
}
