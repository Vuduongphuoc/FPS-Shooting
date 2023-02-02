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

    public bool target = false;
    public AudioSource emptySound;

    public float targetDistance;

    public int damageAmount = 20;

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
                GlobalAmmo.magAmmo -=  (12 - GlobalAmmo.handgunAmmo);
                GlobalAmmo.handgunAmmo += 12;
                if (GlobalAmmo.handgunAmmo > 12)
                {
                    GlobalAmmo.handgunAmmo = 12;
                }

                if(GlobalAmmo.magAmmo == 0)
                {
                    emptySound.Play();
                }
            }
    }
    IEnumerator GunFiring()
    {
        RaycastHit theShot;
        isFiring = true;
        GlobalAmmo.handgunAmmo -= 1;

        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }

        HandGun.GetComponent<Animator>().Play("Gunfire");
        MuzzleFlash.Play();
        Handgunfiresound.Play();
        yield return new WaitForSeconds(0.3f);
        yield return new WaitForSeconds(0.2f);
        HandGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
        

    }
}
