using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevel : MonoBehaviour
{
    public GameObject GameWall1, GameWall2, GameWall3, GameWall4;

    public float spawnRate = 13.5f;

    float nextSpawn = 0f;

    int whatToSpawn;

    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 8);
            Debug.Log("rand_ LEVEL");
            Debug.Log(whatToSpawn);



            switch (whatToSpawn)
            {
                case 1:
                    GameWall1.SetActive(true);
                    GameWall2.SetActive(false);
                    GameWall3.SetActive(false);
                    GameWall4.SetActive(true);
                    break;

                case 2:
                    GameWall1.SetActive(false);
                    GameWall2.SetActive(false);
                    GameWall3.SetActive(false);
                    GameWall4.SetActive(true);
                    break;
                case 3:
                    GameWall1.SetActive(false);
                    GameWall2.SetActive(true);
                    GameWall3.SetActive(true);
                    GameWall4.SetActive(false);
                    break;
                case 4:
                    GameWall1.SetActive(true);
                    GameWall2.SetActive(true);
                    GameWall3.SetActive(true);
                    GameWall4.SetActive(false);
                    break;
                case 5:
                    GameWall1.SetActive(false);
                    GameWall2.SetActive(true);
                    GameWall3.SetActive(true);
                    GameWall4.SetActive(true);
                    break;
                case 6:
                    GameWall1.SetActive(true);
                    GameWall2.SetActive(false);
                    GameWall3.SetActive(false);
                    GameWall4.SetActive(false);
                    break;
                case 7:
                    GameWall1.SetActive(false);
                    GameWall2.SetActive(true);
                    GameWall3.SetActive(false);
                    GameWall4.SetActive(false);
                    break;
                case 8:
                    GameWall1.SetActive(false);
                    GameWall2.SetActive(false);
                    GameWall3.SetActive(true);
                    GameWall4.SetActive(false);
                    break;

            }

            nextSpawn = Time.time + spawnRate;

        }

    }

}
