using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecycleLevel : MonoBehaviour
{
    public GameObject gameOverText1;
    public GameObject gameOverText2;
    public GameObject gameOver;

    void Update()
    {
        Lives.LifeValue -= 1;
        if (Lives.LifeValue == 2)
        {
            gameOverText1.SetActive(true);
            SceneManager.LoadScene(0);
        }
        if (Lives.LifeValue == 1)
        {
            gameOverText2.SetActive(true);
            SceneManager.LoadScene(0);
        }
        if (Lives.LifeValue == 0)
        {
           gameOver.SetActive(true);

        }    
    }
}
