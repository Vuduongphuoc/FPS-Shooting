using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotPlayer : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject EnemyBot;
    public AudioSource firesound;
    public bool isFiring = false;
    public float FireRate = 1.2f;
    public int getHurt;
    public AudioSource[] hurtSound;
    public GameObject hurtFlash;
    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;
            
        }
        if(hitTag == "Player" && isFiring == false )
        {
            StartCoroutine(EnemyFire());
        }
        if(hitTag != "Player")
        {
            EnemyBot.GetComponent<Animator>().Play("Idle");
            lookingAtPlayer = false;
        }

    }
    IEnumerator EnemyFire()
    {
        isFiring = true;
        EnemyBot.GetComponent<Animator>().Play("Shooting");
        firesound.Play();
        lookingAtPlayer = true;
        Health.HpValue -= Random.Range(5,20);
        hurtFlash.SetActive(true);
        yield return new WaitForSeconds(0.06f);
        hurtFlash.SetActive(false);
        getHurt = Random.Range(0, 3);
        hurtSound[getHurt].Play();
        yield return new WaitForSeconds(FireRate);
        isFiring = false;
    }
}
