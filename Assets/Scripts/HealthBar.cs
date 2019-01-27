using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour

{
    static public float CurrentHealth { get; set; }
    static public float MaxHealth { get; set; }

    public Slider healthbar;
    public PlayerController player;

    void Start()
    {
        MaxHealth = 1000f;
        CurrentHealth = MaxHealth;
        healthbar.value = CalculateHealth();

    }

    void Update()
    {
        MaxHealth = player.maxStamina;
        CurrentHealth = player.stamina;
        healthbar.value = CalculateHealth();
    }

    void DealDamage(float DamageValue)
    {
        CurrentHealth -= DamageValue;
        healthbar.value = CalculateHealth();
        if (CurrentHealth <= 0)
            Die();
    }

    float CalculateHealth()
    {
        return CurrentHealth / MaxHealth;
    }


    void Die()
    {
        CurrentHealth = 0;
        Debug.Log("You are Lost Forever");
    }
}
