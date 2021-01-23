using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb = null;
    [SerializeField] public float velocity = 100;

    private void FixedUpdate()
    {
        rb.AddForce(-transform.forward * velocity * Time.deltaTime); 
    }
}
