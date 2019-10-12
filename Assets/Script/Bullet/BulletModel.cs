using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel 
{
    public BulletModel (int damage, int bulletSpeed)
    {
        Damage = damage;
        BulletSpeed = bulletSpeed;
    }
    public int Damage{get;}
    public int BulletSpeed {get;} 
}
