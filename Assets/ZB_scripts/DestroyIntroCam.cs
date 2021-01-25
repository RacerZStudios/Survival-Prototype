using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIntroCam : MonoBehaviour
{
    public float time;
    public GameObject cam;
    [SerializeField] public Init initController; 

    private void Update()
    {
        time += Time.deltaTime;
        if(time >= 20)
        {
            Destroy(cam.gameObject);
            Destroy(this);
            initController.enabled = true; 
        }
    }
}
