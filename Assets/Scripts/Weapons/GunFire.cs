using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UIElements;


public class GunFire : MonoBehaviour
{
    public ParticleSystem MuzzleFlash;

    public AudioSource Handgunfiresound;

    public GameObject HandGun;

    public bool isFiring = false;
    public AudioSource emptySound;
    public float maxDistance;

    // Update is called once per frame
    void Update()
    {
            if (Input.GetButtonDown("Fire1"))
            {
                if(GlobalAmmo.handgunAmmo < 1)
                {
                    emptySound.Play();
                }
                else
                {
                    if (isFiring == false)
                    {
                        StartCoroutine(GunFiring());
                    }
                }

            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                GlobalAmmo.handgunAmmo += 12;
                GlobalAmmo.magAmmo -= 12;
                if(GlobalAmmo.magAmmo == 0)
                {
                    emptySound.Play();
                }
            }
    }
    IEnumerator GunFiring()
    {
        isFiring = true;
        GlobalAmmo.handgunAmmo -= 1;
        HandGun.GetComponent<Animator>().Play("Gunfire");
        MuzzleFlash.Play();
        Handgunfiresound.Play();
        yield return new WaitForSeconds(0.3f);
        yield return new WaitForSeconds(0.2f);
        HandGun.GetComponent<Animator>().Play("New State");
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, maxDistance))
        {
            if (hitInfo.transform.CompareTag("Enemy"))
            {
                //Enemy.Instance.LostHealth(3);
                Debug.Log("Enemy hit");
            }
        }

        isFiring = false;
        

    }
}
