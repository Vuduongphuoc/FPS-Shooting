using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HandGunPickUp : MonoBehaviour
{
    public GameObject RealHandGun;
    public GameObject FakeHandGun;
    public AudioSource PickUpSound;
    public GameObject PickupDisplay;

    void OnTriggerEnter(Collider other)
    {
        RealHandGun.SetActive(true);
        FakeHandGun.SetActive(false);
        PickUpSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        PickupDisplay.SetActive(false);
        PickupDisplay.GetComponent<Text>().text = "Pistol pick up";
        PickupDisplay.SetActive(true);
    }
}
