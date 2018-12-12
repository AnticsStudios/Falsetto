using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnableGameScene : MonoBehaviour {

        List<GameObject> GetAllObjectsInScene()
        {
            List<GameObject> objectsInScene = new List<GameObject>();

            foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
            {
                if (go.hideFlags == HideFlags.NotEditable || go.hideFlags == HideFlags.HideAndDontSave)
                    continue;

                if (!EditorUtility.IsPersistent(go.transform.root.gameObject))
                    continue;

                objectsInScene.Add(go);
            }

            return objectsInScene;
        }
    
    // Use this for initialization
    void Start () {
        GetAllObjectsInScene();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
