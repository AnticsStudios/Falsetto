using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {


    public GameObject Game;
    public GameObject TimeBug;
    //public Scene DannysTest;
    // Use this for initialization
    void Start () {
        TimeBug = GameObject.FindGameObjectWithTag("TimeBugFixer");
        //Game = GameObject.FindGameObjectWithTag("Game");
    }



    void Update()
    {

    }
    public void StartGame()
    {
        //on start button press load character selectio
        //foreach (GameObject Game in allObjects)
      //  {
            //Game.SetActive(true);
            //DontDestroyOnLoad(Game);
       // }

        SceneManager.LoadScene("DannysTest");
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
