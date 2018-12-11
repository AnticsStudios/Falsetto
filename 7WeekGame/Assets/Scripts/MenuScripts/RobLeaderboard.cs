using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobLeaderboard : MonoBehaviour {

    public static int score;

    public static int highscore;

    public GUIText text;

    public InputField type;

    // Use this for initialization
    void Start ()
    {

        text = GetComponent<GUIText>();

        text.text = "";

       // PlayerPrefs.SetInt("highscore", highscore);


    }

    // Update is called once per frame
    void Update ()
    {

      

	}
}
