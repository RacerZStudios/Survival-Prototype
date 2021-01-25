using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private Rigidbody coinRB;
    [SerializeField] private Collider coinCollider;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;
    [SerializeField] private ZombieText_Controller zombieTExt;
    [SerializeField] private GameObject prizeObj; 
    public int CointCount = 0;
    public bool collectedCoin; 

    private void Start()
    {
        coinRB.useGravity = true;
        coinCollider.isTrigger = false;
        CointCount = 0; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collectedCoin = true; 
            CointCount++;
            zombieTExt.text.text = CointCount.ToString() + 1; 
            Debug.Log(CointCount);
            Debug.Log(zombieTExt.text); 
            StartCoroutine(PlayCoinAudio());

            if(collectedCoin == true)
            {
                // Debug.Log("Eliminated All Zombies!" + CointCount);
                Debug.Log("Collected The Prize" + "You may continue");
                Instantiate(prizeObj);
                return; 
            }
        }
    }

    private void Update()
    {
        if(CointCount >= 5 || CointCount != 0)
        {
            collectedCoin = true; 
            return; 
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
