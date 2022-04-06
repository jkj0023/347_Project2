using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewHealth : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    private int key = 0;

    public Healthbar healthBar;
    public PlayerMovement player;

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

        if (curHealth <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void Winner()
    {
        SceneManager.LoadScene("WinnerWinner");
    }

    public void DamagePlayer(int damage)
    {
        curHealth -= damage;

        healthBar.SetHealth(curHealth);
    }

    public void HealPlayer(int damage)
    {
        if (curHealth == 100)
        {
            curHealth += 0;
        }
        else
        {
            curHealth += damage;
        }

        healthBar.SetHealth(curHealth);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            GameOver();
        }
        if ((collision.gameObject.tag == "final") && (key == 1))
        {
            Winner();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            DamagePlayer(20);
            print(curHealth);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Health")
        {
            HealPlayer(10);
            print(curHealth);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Poison")
        {
            DamagePlayer(curHealth);
            print(curHealth);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "GoldenHealth")
        {
            int newhealth = 100 - curHealth;
            HealPlayer(newhealth);
            print(curHealth);
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "Key")
        {
            key++;
            Destroy(collision.gameObject);
            print("Key has been obtained. Go to the finish line");
        }
    }
}