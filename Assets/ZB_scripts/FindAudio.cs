using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAudio : MonoBehaviour
{
    [SerializeField] public GameObject source;

    public void ChecForAudio()
    {
        gameObject.SetActive(false); 

        source = GetComponent<GameObject>();

        GameObject go = GameObject.Find("Audio Source(Clone)"); 
        if(go)
        {
            if (go.activeSelf)
            {
                Destroy(gameObject);
            }
            return; 
        }
    }
}
