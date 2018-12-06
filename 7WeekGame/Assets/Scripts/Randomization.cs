﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6;
    private GameObject randomWall;
    public GameObject letsFixTimeBug;

    public float spawnRate = 13.5f;

    float nextSpawn = 0f;
    private float nextSpawner;
    private void Start()
    {
        //     nextSpawn = -gameObject.GetComponent<LoadSceneScript>().unusableMenuTime; 
        letsFixTimeBug = GameObject.FindGameObjectWithTag("TimeBugFixer");
        nextSpawner = -letsFixTimeBug.GetComponent<timebugfix>().unusableMenuTime;
    }


    int whatToSpawn;


    private void Update()
    {

        if (Time.time - nextSpawner > nextSpawn )
        {
            whatToSpawn = Random.Range(1, 6);
            Debug.Log("rand");
            Debug.Log(whatToSpawn);
            // Destroy(randomWall);
            switch (whatToSpawn)
            {
                case 1:
                    randomWall = Instantiate(prefab1, transform.position, Quaternion.identity) as GameObject;
                    break;

                case 2:
                    randomWall = Instantiate(prefab2, transform.position, Quaternion.identity) as GameObject;
                    break;
                case 3:
                    randomWall = Instantiate(prefab3, transform.position, Quaternion.identity) as GameObject;
                    break;
                case 4:
                    randomWall = Instantiate(prefab4, transform.position, Quaternion.identity) as GameObject;
                    break;
                case 5:
                    randomWall = Instantiate(prefab5, transform.position, Quaternion.identity) as GameObject;
                    break;
                case 6:
                    randomWall = Instantiate(prefab6, transform.position, Quaternion.identity) as GameObject;
                    break;

            }


            nextSpawn = Time.time + spawnRate;

        }

        //if (randomWall.activeInHierarchy)
        //{
        //    Debug.Log("active");
        //}
        //else
        //{
        //    Debug.Log("not");
        //}

    }

}
