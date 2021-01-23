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
    [SerializeField] public GameObject coinObj;
    [SerializeField] public Transform coinSpawnPos;
    [SerializeField] public PlayerHealthController phC;
    public bool isKilled; 
 
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Target")
        {
            slider.value += 0.1f;
            Debug.Log("hit" + projectile); 

            if(slider.value >= 0.1f * 10)
            {
                phC.killedZombie = true; 
            }
            else if(gameObject == null)
            {
                phC.killedZombie = true;
            }
        }
    }

    private void Update()
    {
        if(slider.value >= 1 || slider.value == 1)
        {
            phC.killedZombie = true;
            isKilled = true; 
            Destroy(col.gameObject);
            Destroy(targetObj);
            Destroy(slider.gameObject);
            Instantiate(coinObj, coinSpawnPos.transform.position, coinSpawnPos.transform.rotation); 
            coinActive.enabled = true;
            phC.killedZombie = false;
        }
    }
}
