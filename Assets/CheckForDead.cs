using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForDead : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] public FindAudio fA; 
    public bool deadAudio; 

    private void Awake()
    {
        source = FindObjectOfType<AudioSource>();     
    }

    private void Start()
    {
        if(source != null)
        {
            return; 
        }

        if(deadAudio == true)
        {
            source.enabled = false; 
        }
    }

    private void Update()
    {
        if(gameObject.activeInHierarchy || deadAudio == true)
        {
            fA.ChecForAudio();
        }
    }
}