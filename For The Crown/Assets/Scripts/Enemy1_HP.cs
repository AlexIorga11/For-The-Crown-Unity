using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy1_HP : MonoBehaviour
{
    public Animator animator;
    public float maxHealth = 100;
    float currentHealth;
    public HealthbarBehaviour Healthbar;
    public Gold gold;
    public Stone stone;
    public Wood wood;

    void Start()
    {
        currentHealth = maxHealth;
        Healthbar.SetHealth(currentHealth, maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Healthbar.SetHealth(currentHealth, maxHealth);


        animator.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        int ResourcesDropped = Random.Range(1, 4);
        int goldDropped = Random.Range(10, 30);
        int woodDropped = Random.Range(10, 15);
        int stoneDropped = Random.Range(5, 10);

        switch (ResourcesDropped)
        {

            case 1:
                gold.addGold(goldDropped);
                break;
            case 2:
                gold.addGold(goldDropped);
                wood.addWood(woodDropped);
                break;
            case 3:
                gold.addGold(goldDropped);
                wood.addWood(woodDropped);
                stone.addStone(stoneDropped);
                break;
        }

        Debug.Log("Enemy died");
        GetComponent<Enemy_behaviour>().enabled = false;

        animator.SetBool("isDead", true);
        transform.Find("enemy_collider").gameObject.SetActive(false);
        GetComponent<BoxCollider2D>().enabled = false;        
        Destroy(GetComponent<Rigidbody2D>());
        
        this.enabled = false;
        Destroy(gameObject, 2);
    }
}
