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

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Target")
        {
            slider.value += 0.1f;
            Debug.Log("hit" + projectile); 
        }
    }

    private void Update()
    {
        if(slider.value >= 1)
        {
            Destroy(col.gameObject);
            Destroy(targetObj);
            Destroy(slider.gameObject);
            Instantiate(coinObj, coinSpawnPos.transform.position, coinSpawnPos.transform.rotation); 
            coinActive.enabled = true; 
        }
    }
}
