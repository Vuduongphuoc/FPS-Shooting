using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Lives : MonoBehaviour
{
    public GameObject LifeDisplay;
    public static int LifeValue = 3;
    public int InternalLife;


    // Update is called once per frame
    void Update()
    {
        if(LifeValue <= 0)
        {
            LifeValue = 0;
            SceneManager.LoadScene(1);
        }
        InternalLife = LifeValue;
        LifeDisplay.GetComponent<Text>().text ="" + LifeValue;
    }
}
