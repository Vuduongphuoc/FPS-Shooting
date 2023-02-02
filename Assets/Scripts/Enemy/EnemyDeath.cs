using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 100;
    public bool enemyDeath = false;
    public GameObject enemyAi;
    public GameObject theEnemy;

    public void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    void Update()
    {
        if(enemyHealth <= 0 && enemyDeath == false)
        {
            StartCoroutine(Death());
            
        }
    }
    IEnumerator Death()
    {
        enemyDeath = true;
        theEnemy.GetComponent<Animator>().Play("Enemy Death");
        enemyAi.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        theEnemy.GetComponent<EnemySpotting>().enabled= false;
        Health.HpValue += 50;
        if(Health.HpValue > 100)
        {
            Health.HpValue = 100;
        }
    }
}
