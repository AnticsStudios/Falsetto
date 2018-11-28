using UnityEngine;
using System.Collections;

public class ButtonPress: MonoBehaviour
{

    public AudioSource soundclip;
    

    void Start()
    {
       
    }


    void Update()
    {

    }

    void OnGUI()
    {
        

       
            if (Input.GetMouseButtonDown(0))
            {
                soundclip.Play();
            }


        }
    }

