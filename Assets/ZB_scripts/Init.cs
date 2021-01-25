using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    [SerializeField] public GameObject playerController;
    [SerializeField] public Transform zombieSpawnPos;
    [SerializeField] public GameObject mainCam;
    [SerializeField] public GameObject musicSource;
    [SerializeField] public GameObject zombieCanvas; 

    private void Start()
    {
        Instantiate(playerController, playerController.transform.position, playerController.transform.rotation);
        Instantiate(mainCam, transform.position, Quaternion.identity);
        Instantiate(musicSource);
        Instantiate(zombieCanvas); 
    }
}
