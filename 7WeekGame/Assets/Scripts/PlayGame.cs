using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {
    public GameObject TimeBug;


    // Use this for initialization
    void Start () {

	}
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "main menu")
        {
            TimeBug = GameObject.Find("SceneLoader");
        }
    }
    public void StartGame()
    {
        //on start button press load character selection
        SceneManager.LoadScene("DannysTest");
        TimeBug.GetComponent<LoadSceneScript>().isStarted = true;
    }
    public void menuGame()
    {
        //on start button press load character selection
        SceneManager.LoadScene("main menu");
        GameObject menu = GameObject.Find("MenuButtons");
        GameObject menuButtons = Instantiate(menu) as GameObject;
    }

    // Update is called once per frame

}
