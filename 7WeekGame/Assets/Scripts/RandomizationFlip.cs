using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizationFlip : MonoBehaviour {

    public GameObject prefab1, prefab2, prefab3;
    private GameObject randomWall;
    public GameObject letsFixTimeBug;

    public float spawnRate = 13.5f;
    float nextSpawn = 0f;
    private float nextSpawner;
    private void Start()
    {
        //    nextSpawn = -gameObject.GetComponent<LoadSceneScript>().unusableMenuTime;
        letsFixTimeBug = GameObject.FindGameObjectWithTag("TimeBugFixer");
        nextSpawner = -letsFixTimeBug.GetComponent<timebugfix>().unusableMenuTime;
    }
    int whatToSpawn;

    private void Update()
    {
        if (Time.time - nextSpawner > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 6);
            Debug.Log(whatToSpawn);
            Debug.Log("rand_F");
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


            nextSpawn = Time.time + spawnRate;
        }

    }

}
