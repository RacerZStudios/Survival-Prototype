using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    [SerializeField] public Slider health;
    public float time = 100;
    public int maxTime = 100;
    public int timeChunk1 = 1;
    [SerializeField] public bool killedZombie = false;
    [SerializeField] public EnemyController hC;
    [SerializeField] public GameObject deadPanel;
    [SerializeField] public AudioSource source;
    [SerializeField] public AudioClip clip;
    [SerializeField] public AudioSource sourceMusic;
    [SerializeField] public CheckForDead dead;
    [SerializeField] public GameObject findA;

    private void Awake()
    {
        killedZombie = false; 
    }

    private void Start()
    {
        if(!sourceMusic.isPlaying)
        {
            sourceMusic.gameObject.SetActive(true);
        }

        health.value = 1; 
    }

    private void Update()
    {
        if(findA == null)
        {
            return; 
        }
        else
        {
            findA = GameObject.Find("Find_Audio(Clone)"); 
        }

        if (hC == null)
        {
            return; 
        }

        time -= Time.deltaTime; 

        if(killedZombie == true || hC.isDead == true)
        {
            health.value += 0.5f;
            // untick killedZombie when true 
            killedZombie = false;
            hC.isDead = false; 
        }
        else
        {
            health.value -= 0.0001f;
        }

        if (health.value <= 0)
        {
            dead.deadAudio = true;
            if (dead.deadAudio == true)
            {
                sourceMusic = FindObjectOfType<AudioSource>(); 
                sourceMusic.gameObject.GetComponent<AudioSource>().enabled = false;
            }

            Death(); 
            Instantiate(deadPanel, deadPanel.transform.position, deadPanel.transform.rotation);
            findA.gameObject.SetActive(false); 
            gameObject.SetActive(false); 
        }
    }

    public bool Death()
    {
        return true; 
    }
}
