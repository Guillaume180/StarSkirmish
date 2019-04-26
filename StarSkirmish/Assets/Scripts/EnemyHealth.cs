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

    public void HurtEnemy (int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }

    



}
