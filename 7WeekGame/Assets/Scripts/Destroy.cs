﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    // Use this for initialization

    void OnTriggerEnter(Collider other)
    {
            Destroy(other.gameObject);
    }


}
