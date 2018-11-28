﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3;
    private GameObject randomWall;

    public float spawnRate = 13.5f;

    float nextSpawn = 0f;

    int whatToSpawn;


    private void Update()
    {

        if (Time.time > nextSpawn || Time.time > nextSpawn + 6.75f)
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
