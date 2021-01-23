using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private Rigidbody coinRB;
    [SerializeField] private Collider coinCollider;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;

    private void Start()
    {
        coinRB.useGravity = true;
        coinCollider.isTrigger = false; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(PlayCoinAudio());
        }
    }

    IEnumerator PlayCoinAudio()
    {
        yield return new WaitForSeconds(0.1f);
        source.Play();
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
        yield return null; 
    }
}
