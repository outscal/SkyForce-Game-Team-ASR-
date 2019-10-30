using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponModel
{

    private WeaponScriptableObject weaponScriptableObject;
    // Start is called before the first frame update

    public WeaponModel(WeaponScriptableObject weaponScriptableObject)
    {
        this.weaponScriptableObject = weaponScriptableObject;
        WeaponName = weaponScriptableObject.WeaponName;
    }

    public WeaponModel(string name)
    {
        WeaponName = name;
    }

    public string WeaponName { get; }
}
