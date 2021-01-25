using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAudio : MonoBehaviour
{
    [SerializeField] public GameObject source;

    private void Start()
    {
        if (gameObject == null || enabled == false)
        {
            gameObject.SetActive(true); 
        }

        if(source == null)
        {
            source = FindObjectOfType<GameObject>().GetComponent<GameObject>(); 
        }
    }
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
