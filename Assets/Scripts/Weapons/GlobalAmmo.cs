using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int handgunAmmo;
    public static int magAmmo;
    public GameObject ammoDisplay;
    public GameObject ammoMag;

    void Update()
    {
        ammoDisplay.GetComponent<Text>().text = "" + handgunAmmo;
        ammoMag.GetComponent<Text>().text = "/" + magAmmo;
    }
}
