using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public LayerMask enemyLayers;

    public Transform attackPoint;
    public float attackRange = 1.5f;
    public int attackDamage = 20;
    public float AttackCD = 0.5f;

    private bool canAttack = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }

    void Attack()
    {
        if (canAttack)
        {
            animator.SetTrigger("Attack1");

            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnemies)
            {
                //Debug.Log("Hit : " + enemy.name);
                enemy.GetComponent<Enemy1_HP>().TakeDamage(attackDamage);
            }

            StartCoroutine(JustAttacked());
        }
    }

    IEnumerator JustAttacked()
    {
        canAttack = false;
        yield return new WaitForSeconds(AttackCD);
        canAttack = true;
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
