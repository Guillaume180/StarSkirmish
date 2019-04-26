using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;


    private void Start()
    {
        CurrentHealth = MaxHealth;
    }


    private void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void HurtEnemy ()
    {
        CurrentHealth -= 1;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            Debug.Log("Enemy is hit");
            HurtEnemy();
        }
    }
}
