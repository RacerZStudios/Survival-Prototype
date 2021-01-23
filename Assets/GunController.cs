using System.Collections;
using System.Collections.Generic;
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
    [Range(0.01f, 1.0f)]
    [SerializeField] public float smoothing = 0.5f;
    [SerializeField] public bool lookAtGun = false;
    [SerializeField] public bool rotateAroundGun = true;
    [SerializeField] public float rotationSpeed = 5;

    // roation params
    [SerializeField] Vector3 mPrevPos = Vector3.zero;
    [SerializeField] Vector3 mPosDelta = Vector3.zero;

    [SerializeField] private AudioSource source; 
 
    private void Start()
    {
        fire = false;
        gunObj = this.gameObject;
        rotation = gunObj.transform;

        cameraOffset = transform.position - rotation.position; 
    }

    private void RotateGun()
    {
        mPosDelta = Input.mousePosition - mPrevPos; 
        if(Vector3.Dot(transform.up, Vector3.up) >= 0)
        {
            transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World); 
        }
        else
        {
            transform.Rotate(transform.up, Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
        }

        transform.Rotate(Camera.main.transform.right, Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
    }

    private void Update()
    {
        // Vector3 rotVector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        if (mainCamObj == null)
        {
            return;
        }

        if(cameraZoom == null)
        {
            return; 
        }

        if (Input.GetMouseButton(2))
        {
            RotateGun(); 
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
            cameraZoom.SetActive(true);
            mainCamObj.SetActive(false); 
        }
        else if(!Input.GetMouseButtonUp(1))
        {
            mainCamObj.SetActive(true);
            cameraZoom.SetActive(false);
        }
    }

    public void Fire()
    {
        fire = true; 
        if(fire == true)
        {
            // audio play 
            source.Play(); 
            GameObject prefabPos = Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation); 
        }
    }
}