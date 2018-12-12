using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        GameObject[] objs2 = GameObject.FindGameObjectsWithTag("TimeBugFixer");
        GameObject[] objs3 = GameObject.FindGameObjectsWithTag("menuButtons");

        if (objs.Length > 1) Destroy(this.gameObject);
        if (objs2.Length > 1) Destroy(this.gameObject);
        if (objs3.Length > 1) Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }


}


