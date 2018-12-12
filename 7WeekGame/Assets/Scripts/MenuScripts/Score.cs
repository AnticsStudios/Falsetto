using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Score : MonoBehaviour {


    public GameObject playerScoreUI;
    public Transform scoreDetection;
    private float playerScore;
    private float timeScore;
    private int speed = 5;
    private float distance = 2;
    public GameObject letsFixTimeBug;

    private double[] highscore = new double[10];
    public void scores()
    {




    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("playerTotalScore") != 0)
        {
            playerScore = PlayerPrefs.GetInt("playerTotalScore");
        }
        else
        {
            PlayerPrefs.SetInt("playerTotalScore", 0);
        }

    }

    void Update()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "DannysTest")
        {
            //print UI to screen
            playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
            PlayerPrefs.SetFloat("playerTotalScore", playerScore);
            Debug.DrawLine(scoreDetection.position, Vector2.down);

            RaycastHit2D scoreInfo = Physics2D.Raycast(scoreDetection.position, Vector2.down, distance);

            playerScore = (int)Time.deltaTime + (int)timeScore;
            letsFixTimeBug = GameObject.FindGameObjectWithTag("BackGround");
            letsFixTimeBug.GetComponent<ScrollingBackground>().enabled = true;
        }
        else
        {
            letsFixTimeBug = GameObject.FindGameObjectWithTag("BackGround");
            letsFixTimeBug.GetComponent<ScrollingBackground>().enabled = false;
        }


    }



}
