using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAT_Controller : MonoBehaviour
{
    [SerializeField] public GameObject[] prefabToSpawn;
    [SerializeField] public Transform[] waypoints;
    public bool ZombieKilled;
    public List<GameObject> gameObjects;
    [SerializeField] private EnemyController eC; 

    private void Start()
    {
        Instantiate(prefabToSpawn[0], waypoints[0].transform.position, waypoints[0].transform.rotation);
        Instantiate(prefabToSpawn[1], waypoints[1].transform.position, waypoints[1].transform.rotation);
        Instantiate(prefabToSpawn[2], waypoints[2].transform.position, waypoints[2].transform.rotation);
        Instantiate(prefabToSpawn[3], waypoints[3].transform.position, waypoints[3].transform.rotation);
        Instantiate(prefabToSpawn[4], waypoints[4].transform.position, waypoints[4].transform.rotation);

        gameObjects[0] = prefabToSpawn[0];
        gameObjects[1] = prefabToSpawn[1];
        gameObjects[2] = prefabToSpawn[2];
        gameObjects[3] = prefabToSpawn[3];
        gameObjects[4] = prefabToSpawn[4];
    }

    private void Update()
    {
        if(prefabToSpawn[0] == null)
        {
            prefabToSpawn[0] = GameObject.Find("warzombie_f_pedroso(Clone)").GetComponent<GameObject>();
            return; 
        }
        if (prefabToSpawn[1] == null)
        {
            prefabToSpawn[1] = GameObject.Find("warzombie_f_pedroso(Clone)").GetComponent<GameObject>();
            return;
        }
        if (prefabToSpawn[2] == null)
        {
            prefabToSpawn[2] = GameObject.Find("warzombie_f_pedroso(Clone)").GetComponent<GameObject>();
            return;
        }
        if (prefabToSpawn[3] == null)
        {
            prefabToSpawn[3] = GameObject.Find("warzombie_f_pedroso(Clone)").GetComponent<GameObject>();
            return;
        }
        if (prefabToSpawn[4] == null)
        {
            prefabToSpawn[4] = GameObject.Find("warzombie_f_pedroso(Clone)").GetComponent<GameObject>();
            return;
        }

        if (prefabToSpawn == null && waypoints[0] == null)
        {
            ZombieKilled = true;
            Debug.Log(ZombieKilled);
            return; 
        }

        if (gameObjects[0] == null || prefabToSpawn[0] == null || eC.gameObject == null)
        {
            Debug.Log("Zombie Killed" + "1");
        }
        else if (gameObjects[1] == null || prefabToSpawn[1] == null || eC.gameObject == null)
        {
            Debug.Log("Zombie Killed" + "2");
        }
        else if (gameObjects[2] == null || prefabToSpawn[2] == null || eC.gameObject == null)
        {
            Debug.Log("Zombie Killed" + "3");
        }
        else if (gameObjects[3] == null || prefabToSpawn[3] == null || eC.gameObject == null)
        {
            Debug.Log("Zombie Killed" + "4");
        }
        else if (gameObjects[4] == null || prefabToSpawn[4] == null || eC.gameObject == null)
        {
            Debug.Log("Zombie Killed" + "5");
        }
    }
}