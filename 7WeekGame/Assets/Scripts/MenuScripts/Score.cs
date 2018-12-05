using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
            PlayerPrefs.SetInt("playerTotalScore", 10);
        }
        letsFixTimeBug = GameObject.FindGameObjectWithTag("TimeBugFixer");
        timeScore = -letsFixTimeBug.GetComponent<timebugfix>().unusableMenuTime;
    }

    void Update()
    {

        //print UI to screen
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        PlayerPrefs.SetFloat("playerTotalScore", playerScore);
        Debug.DrawLine(scoreDetection.position, Vector2.down);

        RaycastHit2D scoreInfo = Physics2D.Raycast(scoreDetection.position, Vector2.down, distance);

         playerScore = (int)Time.time + (int)timeScore;
    }



}
