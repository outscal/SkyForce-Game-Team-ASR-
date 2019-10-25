using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel 
{
    public BulletModel (BulletScriptableObject bulletScriptableObject)
    {
        BulletType = bulletScriptableObject.BulletType;
        BulletName = bulletScriptableObject.BulletName;
        BulletDamage = bulletScriptableObject.Damage;
        BulletSpeed = bulletScriptableObject.BulletSpeed;
        BulletPrefab = bulletScriptableObject.bulletPrefab;

        
    }
    public BulletType BulletType {get;}
    public string BulletName {get;}
    public float BulletDamage {get;}
    public float BulletSpeed {get;}
    public int Damage{get;}
    public BulletView BulletPrefab;
     
}
