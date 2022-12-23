using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GunFire : MonoBehaviour
{
    public static Action shootInput;

    public ParticleSystem MuzzleFlash;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            shootInput?.Invoke();
            MuzzleFlash.Play();        
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Reload");
        }
    }
}
