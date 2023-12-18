using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float shootRate = 0.2f;
    private float shootTimer = 0f;
    private bool isShooting = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isShooting = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isShooting = false;
        }

        if (isShooting)
        {
            shootTimer -= Time.deltaTime;

            if (shootTimer <= 0)
            {
                Shoot();
                shootTimer = shootRate;
            }
        }
        else
        {
            shootTimer = 0f;
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
