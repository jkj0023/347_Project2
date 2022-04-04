using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;

    public Healthbar healthBar;

    void Start()
    {
        curHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DamagePlayer(10);
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void DamagePlayer(int damage)
    {
        curHealth -= damage;

        healthBar.SetHealth(curHealth);
    }

    public void HealPlayer(int damage)
    {
        curHealth += damage;

        healthBar.SetHealth(curHealth);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            DamagePlayer(10);
        }

        if (collision.gameObject.tag == "Health")
        {
            HealPlayer(10);
        }

        if (collision.gameObject.tag == "Ground")
        {
            GameOver();
        }
    }
}