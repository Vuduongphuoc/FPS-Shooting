using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public GameObject HPDisplay;
    public static int HpValue;
    public int InternalHP;

    void Start()
    {
        HpValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(HpValue <= 0)
        {
            HpValue = 0;
            SceneManager.LoadScene(1);
        }
        InternalHP = HpValue;
        HPDisplay.GetComponent<Text>().text ="" + HpValue;
    }
}
