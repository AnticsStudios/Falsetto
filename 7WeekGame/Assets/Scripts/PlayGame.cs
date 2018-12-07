using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void StartGame()
    {
        //on start button press load character selection
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
    void Update () {
		
	}
}
