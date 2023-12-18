using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 40;
    private Animator animator;
    public GameObject deathEffect;
    public int basePoints = 10;

    private PointsManager pointsManager;

    void Start()
    {
        animator = GetComponent<Animator>();
        pointsManager = FindObjectOfType<PointsManager>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (animator != null)
        {
            animator.SetTrigger("DieTrigger");
        }

        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);

        if (pointsManager != null)
        {
            pointsManager.AddPoints(basePoints * (int)Mathf.Pow(2, -health)); // Exponential increase in points
        }
    }
}
