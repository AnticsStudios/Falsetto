using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public Animator pauseMenu;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("escape"))
        {
            pauseMenu.ForceStateNormalizedTime(Time.realtimeSinceStartup);
            pauseMenu.SetBool("isHidden", false);
            Time.timeScale = 0;
        }
    }
    public void OpenPauseMenu()
    {
        pauseMenu.SetBool("isHidden", true);
        Time.timeScale = 1;
    }
    public void quitGame()
    {
        Application.Quit();
    }
}

