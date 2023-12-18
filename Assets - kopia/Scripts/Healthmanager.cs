using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;
    public float healingPercentagePerUpdate = 1f;
    public static HealthManager instance;

    void Start()
    {
        UpdateHealthBar();
    }

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        
    }

    public void PlayerTakeDamage(float damage)
    {
        healthAmount -= damage;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);
        UpdateHealthBar();

        if (healthAmount <= 0)
        {
            Die(); 
        }
    }

    void UpdateHealthBar()
    {
        healthBar.fillAmount = healthAmount / 100f;
    }

    void Die()
    {
        Debug.Log("Player died!");
    }
}
