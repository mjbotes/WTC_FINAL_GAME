using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform weaponHold;
    public Gun startingGun;

    private Gun equipedGun;

    private void Start()
    {
        if (startingGun != null)
            EquipGun(startingGun);
    }

    public void EquipGun(Gun gunToEquip)
    {
        if (equipedGun != null)
            Destroy(equipedGun.gameObject);
        equipedGun = Instantiate(gunToEquip, weaponHold.position, weaponHold.rotation) as Gun;
        equipedGun.transform.parent = weaponHold;
    }

    public void Shoot()
    {
        if (equipedGun != null)
            equipedGun.Shoot();
    }
}
