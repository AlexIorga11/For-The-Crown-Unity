using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public Animator animator;
    public float maxHealth = 200;
    public float currentHealth;
    public HealthbarBehaviour Healthbar;
    public float DamageCD = 0.33f;
    public float RegenCD;
    public float regeneration = 20f;

    public bool Invulnerable = false;
    public bool canRegen = true;

    void Start()
    {
        currentHealth = maxHealth;
        Healthbar.SetHealth(currentHealth, maxHealth);        
    }

    public void TakeDamage(int damage)
    {
        RegenCD = 5f;
        canRegen = false;

        if (!Invulnerable)
        {
            currentHealth -= damage;
            Healthbar.SetHealth(currentHealth, maxHealth);

            animator.SetTrigger("Hurt");
            if (currentHealth <= 0)
            {
                Die();               
            }
            else 
            {
                StartCoroutine(TookDamake());
            }


            Debug.Log("Just Hurt");
        }       
    }

    void Die()
    {
        Debug.Log("You died!");

        StopAllCoroutines();
        Invulnerable = true;
        animator.SetBool("isDead", true);
    }

    private void FixedUpdate()
    {
        if (canRegen)
        {
            if (currentHealth <= maxHealth)
            {
                currentHealth += regeneration * Time.deltaTime;
                Healthbar.SetHealth(currentHealth, maxHealth);
            }
            else
            {
                currentHealth = maxHealth;
            }
        }        
    }

    private void Update()
    {
        if(canRegen == false)
        {
            RegenCD -= Time.deltaTime;
            if(RegenCD <= 0)
            {
                canRegen = true;
            }
        }
    }

    IEnumerator TookDamake()
    {
        Invulnerable = true;
        yield return new WaitForSeconds(DamageCD);
        Invulnerable = false;       
    }

    IEnumerator InCombat()
    {
        canRegen = false;
        yield return new WaitForSeconds(RegenCD);
        canRegen = true;
    }
}