using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal; 
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] public GameObject gunObj = null;
    [SerializeField] public Transform bulletSpawn = null;
    [SerializeField] public GameObject bulletPrefab = null; 
    [SerializeField] public bool fire;
    [SerializeField] public Transform rotation = null;
    [SerializeField] public float rotateSpeed = 45;
    [SerializeField] public GameObject cameraZoom = null;
    [SerializeField] public GameObject mainCamObj = null;
    [SerializeField] public Vector3 cameraOffset;

    [SerializeField] private AudioSource source;
    [SerializeField] public CheckForZooming zoom;
    [SerializeField] public ZoomEffect zoomed; 
 
    private void Start()
    {
        fire = false;
        gunObj = this.gameObject;
        rotation = gunObj.transform;

        cameraOffset = transform.position - rotation.position; 
    }

    private void Update()
    {
        if (mainCamObj == null)
        {
            return;
        }

        if(cameraZoom == null)
        {
            return; 
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            fire = false; 
        }

        if(Input.GetMouseButton(1))
        {
            zoom.Zooming();
            cameraZoom.SetActive(true);
            mainCamObj.SetActive(false); 
        }
        else if(!Input.GetMouseButtonUp(1))
        {
            zoom.NotZooming(); 
            mainCamObj.SetActive(true);
            cameraZoom.SetActive(false);
        }
    }

    public void Fire()
    {
        fire = true; 
        if(fire == true)
        {
            source.Play(); 
            GameObject prefabPos = Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation); 
        }
    }
}