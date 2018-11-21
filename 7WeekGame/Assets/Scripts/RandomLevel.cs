using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevel : MonoBehaviour
{
    public GameObject Wall1, Wall2, Wall3, Wall4;
    public GameObject randomNumOfWall1;
    public GameObject randomNumOfWall2;
    public GameObject randomNumOfWall3;
    public GameObject randomNumOfWall4;

    public float spawnRate = 200f;

    float nextSpawn = 0f;

    int whatToSpawn;

    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 6);
            Debug.Log(whatToSpawn);
            Destroy(randomNumOfWall1);
            Destroy(randomNumOfWall2);
            Destroy(randomNumOfWall3);
            Destroy(randomNumOfWall4);

            switch (whatToSpawn)
            {
                case 1:
                    randomNumOfWall1 = Instantiate(Wall1, transform.position, Quaternion.identity) as GameObject;
                    randomNumOfWall2 = null;
                    randomNumOfWall3 = null;
                    randomNumOfWall4 = Instantiate(Wall4, transform.position, Quaternion.identity) as GameObject;
                    break;

                case 2:
                    randomNumOfWall1 = null;
                    randomNumOfWall2 = Instantiate(Wall2, transform.position, Quaternion.identity) as GameObject;
                    randomNumOfWall3 = Instantiate(Wall3, transform.position, Quaternion.identity) as GameObject;
                    randomNumOfWall4 = null;
                    break;
                case 3:
                    randomNumOfWall1 = Instantiate(Wall1, transform.position, Quaternion.identity) as GameObject;
                    randomNumOfWall2 = Instantiate(Wall2, transform.position, Quaternion.identity) as GameObject;
                    randomNumOfWall3 = Instantiate(Wall3, transform.position, Quaternion.identity) as GameObject;
                    randomNumOfWall4 = null;
                    break;
                case 4:
                    randomNumOfWall1 = null;
                    randomNumOfWall2 = null;
                    randomNumOfWall3 = null;
                    randomNumOfWall4 = null;
                    break;

            }


            nextSpawn = Time.time + spawnRate;

        }

    }

}
