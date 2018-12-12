using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Randomization : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3;
    public GameObject randomWall;
    //public GameObject letsFixTimeBug;

    public float spawnRate = 13.5f;

    float nextSpawn = 0f;
    private float nextSpawner;
    private float unusabletime;

    private void Start()
    {
        //unusabletime = -Time.time;
    }


    public int whatToSpawn;


    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "DannysTest")
        {
            nextSpawner = Time.time;
            if (nextSpawner /*+ unusabletime*/> nextSpawn)
            {
                whatToSpawn = Random.Range(1, 3);
                //  Debug.Log("rand");
                // Debug.Log(whatToSpawn);
                Destroy(randomWall);
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

                randomWall.GetComponent<ScrollingBackground>().enabled = true;

                nextSpawn = nextSpawner + spawnRate;
            }
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
