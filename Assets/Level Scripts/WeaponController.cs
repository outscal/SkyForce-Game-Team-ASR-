using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController
{
    WeaponScriptableObject weaponScriptableObject;
    
    public WeaponController(WeaponModel weaponModel, WeaponView weaponPrefab)
    {
        WeaponModel = weaponModel;
        WeaponView = Object.Instantiate(weaponPrefab);
        Debug.Log("Weapons added in list");

        //WeaponView.name = weaponScriptableObject.WeaponName;
        //WeaponView.transform.SetParent(weaponListParent);
        WeaponView.Initalise(this);
        //Debug.Log("weapon view created", WeaponView);
    }

    public void Disable()
    {
        WeaponView.Disable();
    }

    public void Enable()
    {
        WeaponView.Enable();
    }

    public WeaponModel WeaponModel { get; }
    public WeaponView WeaponView { get; }
}
