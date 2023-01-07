using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmmoPickup : MonoBehaviour
{
    public GameObject FakeAmmoClip;
    public AudioSource AmmoPickUpSound;
    public GameObject PickupDisplay;

    void OnTriggerEnter(Collider other)
    {
        FakeAmmoClip.SetActive(false);
        AmmoPickUpSound.Play();
        GlobalAmmo.handgunAmmo += 12;
        GlobalAmmo.magAmmo += 60;
        PickupDisplay.SetActive(false);
        PickupDisplay.GetComponent<Text>().text = "Ammo pick up";
        PickupDisplay.SetActive(true);
    }
}
