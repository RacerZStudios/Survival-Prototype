using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForNull : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] private AudioSource source;

    private void Start()
    {
        if(player == null)
        {
            player = GameObject.Find("First person controller bare");
            player.GetComponent<GameObject>();
            return; 
        }
    }

    private void Update()
    {
        if(source.isPlaying && player != isActiveAndEnabled || player == null)
        {
            source.enabled = false;
            source.volume = 0;
            return;
        }    
    }
}
