using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private PlayerAnimator panimator;

    [SerializeField] private int attackDamage = 10; // Cantidad de da�o por ataque

    private void Start()
    {
        panimator = GetComponentInChildren<PlayerAnimator>();
    }

    private void Update()
    {
        // Ataque 1: Por ejemplo, usando el bot�n izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            panimator.AttackAnimation("LeftPunch");
            Attack(); // Llama a la funci�n Attack para causar da�o
        }

        // Ataque 2: Por ejemplo, usando el bot�n derecho del mouse
        if (Input.GetMouseButtonDown(1))
        {
            panimator.AttackAnimation("RightPunch");
            Attack(); // Llama a la funci�n Attack para causar da�o
        }
    }

    // Funci�n para causar da�o al enemigo
    private void Attack()
    {
        // Encuentra todos los enemigos en el �rea de ataque del jugador (ajusta el radio seg�n tu necesidad)
        Collider[] hitEnemies = Physics.OverlapSphere(transform.position, 1.0f);

        // Itera a trav�s de los enemigos golpeados y les causa da�o
        foreach (Collider enemy in hitEnemies)
        {
            if (enemy.CompareTag("Enemy"))
            {
                // Accede al script de salud del enemigo y causa da�o
                EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(attackDamage);
                }
            }
        }
    }
}
