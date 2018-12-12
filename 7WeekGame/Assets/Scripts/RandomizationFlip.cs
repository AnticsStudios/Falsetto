using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomizationFlip : MonoBehaviour
{

    public GameObject prefab1, prefab2, prefab3;
    public GameObject randomWall;

    public float spawnRate = 13.5f;
    float nextSpawn = 0f;

    private void Start()
    {
        //    nextSpawn = -gameObject.GetComponent<LoadSceneScript>().unusableMenuTime;
    }
    public int whatToSpawn;
    private float nextSpawner;

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "DannysTest")
        {
            nextSpawner = Time.time;
            if (nextSpawner > nextSpawn)
            {
                whatToSpawn = Random.Range(1, 3);
                // Debug.Log(whatToSpawn);
                // Debug.Log("rand_F");
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
                randomWall.transform.Rotate(0f, 180f, 180f);
                randomWall.GetComponent<ScrollingBackground>().enabled = true;

                nextSpawn = Time.time + spawnRate;
            }
        }

    }

}
