using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] public Slider slider = null;
    [SerializeField] public Collider col = null;
    [SerializeField] public GameObject projectile = null;
    [SerializeField] public GameObject targetObj;
    [SerializeField] public CoinController coinActive;
    [SerializeField] public GameObject[] coinObj;
    [SerializeField] public Transform coinSpawnPos;
    [SerializeField] public PlayerHealthController phC;
    public bool isKilled;
    [SerializeField] public int zombiesAlive = 5;
    [SerializeField] public ZombieText_Controller zombieTextController;
    [SerializeField] public HealthController[] healthControllers;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Target")
        {
            slider.value += 0.1f;
            Debug.Log("hit" + projectile); 

            if(slider.value >= 0.1f * 10)
            {
                phC.killedZombie = true;
                for(int i = 0; i < zombieTextController.ZombiesAlive; i++)
                {
                    if(zombieTextController.ZombiesAlive != 0)
                    {
                        isKilled = true;
                        zombieTextController.text.text = zombieTextController.ZombiesAlive.ToString();
                        zombiesAlive--;
                        Debug.Log(zombiesAlive);
                    }
                }
            }
        }
    }

    private void Update()
    {
        if (slider.value >= 1 || slider.value == 1)
        {
            phC.killedZombie = true;

            isKilled = true; 
            Destroy(col.gameObject);
            Destroy(targetObj);
            Destroy(slider.gameObject);
            Instantiate(coinObj[Random.Range(0, coinObj.Length)], coinSpawnPos.transform.position, coinSpawnPos.transform.rotation); 
            coinActive.enabled = true;
            zombieTextController.colelctedCoin = true;
            zombieTextController.KilledZombie(); 
            Debug.Log(zombieTextController.colelctedCoin); 
        }

        if (zombiesAlive <= 0 && zombieTextController.text.text != "5")
        {
            Debug.Log("All Zombies Eliminated" + zombiesAlive.ToString());
            return; 
        }
    }
}
