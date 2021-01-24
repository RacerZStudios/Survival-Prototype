using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForHitPlayer : MonoBehaviour
{
    [SerializeField] public AudioSource source;
    [SerializeField] public AudioClip clip; 
    [SerializeField] public GameObject player; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            source.clip.name = "troll_monster_hurt_pain_01";
            source.PlayOneShot(clip, 1f);
            player.GetComponent<PlayerHealthController>().health.value -= 0.001f;
            return; 
        }
    }
}