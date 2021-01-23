using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAT_Controller : MonoBehaviour
{
    [SerializeField] public GameObject prefabToSpawn;
    [SerializeField] public Transform[] waypoints;

    private void Start()
    {
        Instantiate(prefabToSpawn, waypoints[0].transform.position, waypoints[0].transform.rotation);
        Instantiate(prefabToSpawn, waypoints[1].transform.position, waypoints[1].transform.rotation);
        Instantiate(prefabToSpawn, waypoints[2].transform.position, waypoints[2].transform.rotation);
        Instantiate(prefabToSpawn, waypoints[3].transform.position, waypoints[3].transform.rotation);
        Instantiate(prefabToSpawn, waypoints[4].transform.position, waypoints[4].transform.rotation);
    }
}
