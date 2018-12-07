using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneScript : MonoBehaviour
{
    //declare animators for the buttons, this can be set in unity 
    public Animator startButton;
    public Animator settingsButton;
    public Animator quitButton;
    public Animator dialog;
    public Animator divider;
    public Animator title;
    public Animator leaderboard;
    public Animator leaderboardButton;
    public bool isStarted;

    public void Update()
    {

            startButton = GameObject.Find("Btn_Start").GetComponent<Animator>();
            settingsButton = GameObject.Find("Btn_Settings").GetComponent<Animator>();
            quitButton = GameObject.Find("Btn_Quit").GetComponent<Animator>();
            dialog = GameObject.Find("Btn_Settings").GetComponent<Animator>();
            divider = GameObject.Find("Panel").GetComponent<Animator>();
            title = GameObject.Find("Img_Header").GetComponent<Animator>();
            leaderboard = GameObject.Find("Dlg_Leaderboard").GetComponent<Animator>();
            leaderboardButton = GameObject.Find("Btn_Leaderboard").GetComponent<Animator>();
        startButton.GetComponent<Button>().onClick.AddListener(GameObject.Find("SceneLoader").GetComponent<LoadSceneScript>().StartGame);
        settingsButton.GetComponent<Button>().onClick.AddListener(GameObject.Find("SceneLoader").GetComponent<LoadSceneScript>().OpenSettings);
        quitButton.GetComponent<Button>().onClick.AddListener(GameObject.Find("SceneLoader").GetComponent<LoadSceneScript>().quitGame);
        leaderboardButton.GetComponent<Button>().onClick.AddListener(GameObject.Find("SceneLoader").GetComponent<LoadSceneScript>().OpenLeaderboard);

    }



    public void StartGame()
    {
        //on start button press load character selection
        SceneManager.LoadScene("CharacterSelect");
        isStarted = true;
    }


    public void OpenSettings()
    {
        //open settings and hide all other buttons
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);
        quitButton.SetBool("isHidden", true);
        divider.SetBool("isHidden", true);
        dialog.SetBool("isHidden", false);
        leaderboard.SetBool("isHidden", true);
        leaderboardButton.SetBool("isHidden", true);
        title.SetBool("isHidden", true);
    }

    public void CloseSettings()
    {
        //close settings, and show all other buttons
        startButton.SetBool("isHidden", false);
        settingsButton.SetBool("isHidden", false);
        quitButton.SetBool("isHidden", false);
        divider.SetBool("isHidden", false);
        dialog.SetBool("isHidden", true);
        title.SetBool("isHidden", false);
        leaderboard.SetBool("isHidden", true);
        leaderboardButton.SetBool("isHidden", false);
    }

    public void OpenLeaderboard()
    {
        //open settings and hide all other buttons
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);
        quitButton.SetBool("isHidden", true);
        divider.SetBool("isHidden", true);
        dialog.SetBool("isHidden", true);
        leaderboard.SetBool("isHidden", false);
        leaderboardButton.SetBool("isHidden", true);
        title.SetBool("isHidden", true);
    }

    public void CloseLeaderboard()
    {
        //close settings, and show all other buttons
        startButton.SetBool("isHidden", false);
        settingsButton.SetBool("isHidden", false);
        quitButton.SetBool("isHidden", false);
        divider.SetBool("isHidden", false);
        dialog.SetBool("isHidden", true);
        leaderboard.SetBool("isHidden", true);
        leaderboardButton.SetBool("isHidden", false);
        title.SetBool("isHidden", false);
    }

    public void quitGame()
    {
        //quit game on quit press
        Application.Quit();
    }

}
