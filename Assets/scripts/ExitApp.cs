using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitApp : MonoBehaviour
{
    private Button Logout;

    // Start is called before the first frame update
    void Start()
    {
        Logout = GetComponent<Button>();
        Logout.onClick.AddListener(QuitApp);
    }

    private void QuitApp()
    {
        Debug.Log("In quitapp");
        Application.Quit();
    }
}
