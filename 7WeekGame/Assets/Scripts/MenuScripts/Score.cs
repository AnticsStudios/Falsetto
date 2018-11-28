using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {


    public GameObject playerScoreUI;
    public Transform scoreDetection;
    private float playerScore;
    private int speed = 5;
    private float distance = 2;

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
    }

    void Update()
    {

        //print UI to screen
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        PlayerPrefs.SetFloat("playerTotalScore", playerScore);
        Debug.DrawLine(scoreDetection.position, Vector2.down);

        RaycastHit2D scoreInfo = Physics2D.Raycast(scoreDetection.position, Vector2.down, distance);

         playerScore = (int)Time.time;
    }



}
