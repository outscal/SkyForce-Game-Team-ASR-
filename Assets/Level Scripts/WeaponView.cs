using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponView : MonoBehaviour
{
    private WeaponController weaponController;

    internal void Enable()
    {
        gameObject.SetActive(true);
    }

    internal void Disable()
    {
        gameObject.SetActive(false);
    }
    public void Initalise(WeaponController weaponController)
    {
        this.weaponController = weaponController;
    }
}
