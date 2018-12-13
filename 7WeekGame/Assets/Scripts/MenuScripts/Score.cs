using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Score : MonoBehaviour {


    public GameObject playerScoreUI;
    public Transform scoreDetection;
    private float playerScore;
    private float distance = 2;
    public GameObject letsFixTimeBug;
    public GameObject letsFixTimeBug2;
    public GameObject letsFixTimeBug3;
    public void scores()
    {




    }
    private void Start()
    {
        letsFixTimeBug = GameObject.FindGameObjectWithTag("Game");
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


        if (letsFixTimeBug.GetComponent<ReadyGame>().started2 == true)
        {
            //print UI to screen
            playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
            PlayerPrefs.SetFloat("playerTotalScore", playerScore);
            Debug.DrawLine(scoreDetection.position, Vector2.down);

            RaycastHit2D scoreInfo = Physics2D.Raycast(scoreDetection.position, Vector2.down, distance);

            playerScore = (int)Time.time - letsFixTimeBug.GetComponent<ReadyGame>().timefloat2;
            letsFixTimeBug2 = GameObject.FindGameObjectWithTag("BackGround");
            letsFixTimeBug2.GetComponent<ScrollingBackground>().enabled = true;
            letsFixTimeBug3.GetComponent<Animator>().enabled = true;
    
        }
        else
        {
            letsFixTimeBug2 = GameObject.FindGameObjectWithTag("BackGround");
            letsFixTimeBug2.GetComponent<ScrollingBackground>().enabled = false;
            letsFixTimeBug3.GetComponent<MovePlayer>().enabled = false;
        }


    }



}
