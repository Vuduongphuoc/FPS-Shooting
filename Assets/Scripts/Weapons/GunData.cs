using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunData : ScriptableObject
{
    public new string name;

    public float damage;
    public float maxDistance;

    public int CurrentAmo;
    public int MagSize;
    public float fireRate;
    public float reloadTime;
}
