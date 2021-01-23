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
    public bool killedZombie;
    [SerializeField] public EnemyController hC;
    [SerializeField] public GameObject deadPanel; 

    private void Update()
    {
        if(hC == null)
        {
            return; 
        }

        time -= Time.deltaTime; 

        if(killedZombie == true || hC.isDead == true)
        {
            health.value += 0.5f;
            Debug.Log(health);
            Debug.Log(killedZombie); 
        }
        else
        {
            health.value -= 0.0001f; 
        }

        if(health.value <= 0)
        {
            Instantiate(deadPanel, deadPanel.transform.position, deadPanel.transform.rotation); 
            gameObject.SetActive(false); 
        }
    }
}
