using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunPickUp : MonoBehaviour
{
    public GameObject RealHandGun;
    public GameObject FakeHandGun;
    public AudioSource PickUpSound;

    void OnTriggerEnter(Collider other)
    {
        RealHandGun.SetActive(true);
        FakeHandGun.SetActive(false);
        PickUpSound.Play();
        GetComponent<BoxCollider>().enabled = false;
    }
}
