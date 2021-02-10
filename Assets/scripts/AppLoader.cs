using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppLoader : MonoBehaviour
{
    Image LoadBG;
    public float maxtime = 8f;
    float timeleft;
    public GameObject Loadingscreen;
    public GameObject MainLogin;
    //public GameObject Scanner;

    void Start()
    {
       // Scanner.SetActive(false);
        LoadBG = GetComponent<Image>();
        timeleft = maxtime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            LoadBG.fillAmount = timeleft / maxtime;
        }
        else
        {
            Loadingscreen.SetActive(false);
            MainLogin.SetActive(true);
         }
    }
}
