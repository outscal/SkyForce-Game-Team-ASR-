using SkyForce.Bullet;
using UnityEngine;
[CreateAssetMenu(fileName="BulletScriptableObject",menuName="ScriptableObjects/Bullet/NewBulletScriptableObject")]
public class BulletScriptableObject : ScriptableObject
{
    public BulletType  BulletType;
    public string BulletName;
    public float Damage;
    public float BulletSpeed;
    public BulletView bulletPrefab;
    

}
