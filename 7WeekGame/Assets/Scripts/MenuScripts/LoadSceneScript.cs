using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



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
