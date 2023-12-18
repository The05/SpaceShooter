using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 40;
    private Animator animator;
    public GameObject deathEffect;
    public int basePoints = 1;
    public int damage = 10;

    public float asteroidDamage = 30f;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthManager healthManager = HealthManager.instance;
            if (healthManager != null)
            {
                healthManager.PlayerTakeDamage(asteroidDamage);
            }

            Die();
        }
    }

    public void TakeDamage()
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (animator != null)
        {
            animator.SetTrigger("DieTrigger");
        }

        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
        PointsManager.instance.AddPoint();
        PointsManager.instance.UpdateMultiplier();
    }
}
