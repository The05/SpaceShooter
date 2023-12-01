using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 40;
    private Animator animator;
    public GameObject deathEffect;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die () 
    {
        if (animator != null)
        {
            animator.SetTrigger("DieTrigger");
        }

        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
