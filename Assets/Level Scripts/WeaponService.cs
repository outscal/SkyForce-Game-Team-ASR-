using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponService : MonoBehaviour
{
    public WeaponView weaponView;
    public WeaponScriptableObjectList weaponList;
    
    public List<WeaponController> weapon = new List<WeaponController>();
    WeaponModel model;
    WeaponScriptableObject weaponScriptableObject;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            weaponScriptableObject = weaponList.weapons[i];
            Debug.Log("Creating Weapon with name: " + weaponScriptableObject.WeaponName);
            model = new WeaponModel(weaponScriptableObject);
            weapon.Add(new WeaponController(model, weaponView));
            weapon[i].Disable();
        }
    }

    void Update()
    {
       
        //Debug.Log(totalWeapons);

    }

    public void DisplayWeapon(int j)
    {
        //weapons[i].SetActive(true);
        //for(int j=0;j<weapons.Count;j++)
        //{
        //    if (i != j)
        //        weapons[j].SetActive(false);
        //}
        if (weaponList.weapons[j].WeaponName == "Weapon " + j)
        {
            weapon[j].Enable();
        }
        for (int i = 0; i < 10; i++)
        {
            if (i != j)
                weapon[i].Disable();
        }

    }
}
