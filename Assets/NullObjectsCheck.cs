using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullObjectsCheck : MonoBehaviour
{
    public List<GameObject> gameObjects;

    private void Start()
    {
        gameObjects[0] = gameObject;
        gameObjects[1] = gameObject;
        gameObjects[2] = gameObject;
        gameObjects[3] = gameObject;
        gameObjects[4] = gameObject; 
    }

    private void LateUpdate()
    {
        if(gameObjects[0] || gameObjects[1] || gameObjects[2] || gameObjects[3] || gameObjects[4])
        {
            Debug.Log("Working"); 
        }
    }
}
