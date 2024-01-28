using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    
    //public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackDamage = 10;
    public float attackRange = 0.5f;
  /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
    }

    void Attack()
    {
        // Play an attack animation
        // animator.SetTrigger("Attack");

        // Detects enemies in range of attack
        Collider2D [] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        //enemy = GameObject.FindGameObjectWithTag("Enemy")

        // Damage them
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy_Health>().TakeDamage(attackDamage);    //null reference fejl
        
        }
    }

    
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)    // Only draws if there is an attackpoint
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
  */
}
