using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeGlass : MonoBehaviour {

    public GameObject prefab1, prefab2, prefab3;
    public GameObject randomGlass;
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
    public int whatToSpawn;

    private void Update()
    {
        if (Time.time - nextSpawner > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 3);
           // Debug.Log(whatToSpawn);
           // Debug.Log("rand_G");
            Destroy(randomGlass);

            switch (whatToSpawn)
            {
                case 1:
                    randomGlass = Instantiate(prefab1, transform.position, Quaternion.identity) as GameObject;
                    break;

                case 2:
                    randomGlass = Instantiate(prefab2, transform.position, Quaternion.identity) as GameObject;
                    break;
                case 3:
                    randomGlass = Instantiate(prefab3, transform.position, Quaternion.identity) as GameObject;
                    break;


            }

            nextSpawn = Time.time + spawnRate;
        }

    }
}
