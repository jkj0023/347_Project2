using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider healthBar;
    public Health playerHealth;
    public int maxValue = 0;
    public int value = 0;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = playerHealth.maxHealth;
        healthBar.value = playerHealth.maxHealth;
    }

    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}
