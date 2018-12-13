using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public GameObject potato;
    // Use this for initialization
    private void Update()
    {
        Vector3 temp = new Vector3(-12.5f, 0.6300049f, 0);
        potato.transform.position = temp;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
            Destroy(other.gameObject);
    }


}
