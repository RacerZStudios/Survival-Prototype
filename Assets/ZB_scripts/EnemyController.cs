using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] public Vector3 targetA;
    [SerializeField] public Vector3 targetB;
    [SerializeField] public Transform target;
    [SerializeField] public GameObject player; 
    [SerializeField] public float range = 5;
    [SerializeField] public Animator animator;
    [SerializeField] public EnemyController[] controllers;
    [SerializeField] public AudioSource source;
    [SerializeField] public AudioClip clip; 

    public bool isDead; 

    private void Start()
    {
        for (int i = 0; i < targetA.magnitude; i++)
        {
            targetA.Equals(this);
            animator = GetComponent<Animator>();
        }

        if(target == null)
        {
            return; 
        }
        else
        {
            player.transform.position = targetB;
        }

        if(player == null)
        {
            return; 
        }

        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    private void Update()
    {
        if (gameObject == null)
        {
            isDead = true; 
            return; 
        }

        targetA = transform.position;
        targetB = player.transform.position;

        if (Vector3.Distance(targetB, targetA) <= range)
        {
            transform.LookAt(player.transform);
            targetA = Vector3.MoveTowards(targetA, targetB, 2);
            targetA -= targetB;
            animator.Play("Attack");
            animator.SetBool("CanAttack", true);
            animator.SetBool("Idle", false);
        }
        else if(Vector3.Distance(targetB, targetA) > range)
        {
            animator.Play("Idle");
            animator.SetBool("Idle", true);
            animator.SetBool("CanAttack", false);
            return; 
        }
    }
}