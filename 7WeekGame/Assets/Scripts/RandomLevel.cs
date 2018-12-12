using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomLevel : MonoBehaviour
{
    public GameObject GameWall1, GameWall2, GameWall3, GameWall4, GameGlass1, GameGlass2, GameGlass3, GameGlass4;
     
    public float spawnRate = 13.5f;
    private float nextSpawn = 0f;
    private float nextSpawner;
    public int whatToSpawn;
    public float unusabletime;

    private void Start()
    {
       //unusabletime = -Time.time;
    }

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "DannysTest")
        {
            nextSpawner = Time.time;

            if ((nextSpawner) > nextSpawn)
            {
                whatToSpawn = Random.Range(1, 8);
                // Debug.Log("rand_ LEVEL");
                // Debug.Log(whatToSpawn);

                switch (whatToSpawn)
                {
                    case 1:
                        GameWall1.SetActive(true);
                        GameWall2.SetActive(false);
                        GameWall3.SetActive(false);
                        GameWall4.SetActive(true);

                        GameGlass1.SetActive(false);
                        GameGlass2.SetActive(true);
                        GameGlass3.SetActive(true);
                        GameGlass4.SetActive(false);
                        break;

                    case 2:
                        GameWall1.SetActive(false);
                        GameWall2.SetActive(false);
                        GameWall3.SetActive(false);
                        GameWall4.SetActive(true);


                        GameGlass1.SetActive(true);
                        GameGlass2.SetActive(true);
                        GameGlass3.SetActive(true);
                        GameGlass4.SetActive(false);
                        break;
                    case 3:
                        GameWall1.SetActive(false);
                        GameWall2.SetActive(true);
                        GameWall3.SetActive(true);
                        GameWall4.SetActive(false);

                        GameGlass1.SetActive(true);
                        GameGlass2.SetActive(false);
                        GameGlass3.SetActive(false);
                        GameGlass4.SetActive(true);
                        break;
                    case 4:
                        GameWall1.SetActive(true);
                        GameWall2.SetActive(true);
                        GameWall3.SetActive(true);
                        GameWall4.SetActive(false);

                        GameGlass1.SetActive(false);
                        GameGlass2.SetActive(false);
                        GameGlass3.SetActive(false);
                        GameGlass4.SetActive(true);
                        break;
                    case 5:
                        GameWall1.SetActive(false);
                        GameWall2.SetActive(true);
                        GameWall3.SetActive(true);
                        GameWall4.SetActive(true);

                        GameGlass1.SetActive(true);
                        GameGlass2.SetActive(false);
                        GameGlass3.SetActive(false);
                        GameGlass4.SetActive(false);
                        break;
                    case 6:
                        GameWall1.SetActive(true);
                        GameWall2.SetActive(false);
                        GameWall3.SetActive(false);
                        GameWall4.SetActive(false);

                        GameGlass1.SetActive(false);
                        GameGlass2.SetActive(true);
                        GameGlass3.SetActive(true);
                        GameGlass4.SetActive(true);
                        break;
                    case 7:
                        GameWall1.SetActive(false);
                        GameWall2.SetActive(true);
                        GameWall3.SetActive(false);
                        GameWall4.SetActive(false);

                        GameGlass1.SetActive(true);
                        GameGlass2.SetActive(false);
                        GameGlass3.SetActive(true);
                        GameGlass4.SetActive(true);
                        break;
                    case 8:
                        GameWall1.SetActive(false);
                        GameWall2.SetActive(false);
                        GameWall3.SetActive(true);
                        GameWall4.SetActive(false);

                        GameGlass1.SetActive(true);
                        GameGlass2.SetActive(true);
                        GameGlass3.SetActive(false);
                        GameGlass4.SetActive(true);
                        break;
                        //   2.6
                        //  1.13
                        // -0.58
                        //    -2.05
                }

                nextSpawn = nextSpawner + spawnRate;
            }
        }

    }

}
