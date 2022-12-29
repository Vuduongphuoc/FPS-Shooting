using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject FakeAmmoClip;
    public AudioSource AmmoPickUpSound;

    void OnTriggerEnter(Collider other)
    {
        FakeAmmoClip.SetActive(false);
        AmmoPickUpSound.Play();
        GlobalAmmo.handgunAmmo += 12;
        GlobalAmmo.magAmmo += 60;
    }
}
