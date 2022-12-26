using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class GunFire : MonoBehaviour
{
    public ParticleSystem MuzzleFlash;

    public AudioSource Handgunfiresound;

    public GameObject HandGun;

    public bool isFiring = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetButtonDown("Fire1"))
            {
                if (isFiring == false)
                {
                    StartCoroutine(GunFiring());
                }

            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("Reload");
            }
    }
    IEnumerator GunFiring()
    {
        isFiring = true;
        HandGun.GetComponent<Animator>().Play("Gunfire");
        MuzzleFlash.Play();
        Handgunfiresound.Play();
        yield return new WaitForSeconds(0.3f);
        yield return new WaitForSeconds(0.3f);
        HandGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
        

    }
}
