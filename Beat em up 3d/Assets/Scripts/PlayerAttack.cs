using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private PlayerAnimator panimator;

    [SerializeField] private int attackDamage = 10; // Cantidad de daño por ataque

    private void Start()
    {
        panimator = GetComponentInChildren<PlayerAnimator>();
    }

    private void Update()
    {
        // Ataque 1: Por ejemplo, usando el botón izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            panimator.AttackAnimation("LeftPunch");
            Attack(); // Llama a la función Attack para causar daño
        }

        // Ataque 2: Por ejemplo, usando el botón derecho del mouse
        if (Input.GetMouseButtonDown(1))
        {
            panimator.AttackAnimation("RightPunch");
            Attack(); // Llama a la función Attack para causar daño
        }
    }

    // Función para causar daño al enemigo
    private void Attack()
    {
        // Encuentra todos los enemigos en el área de ataque del jugador (ajusta el radio según tu necesidad)
        Collider[] hitEnemies = Physics.OverlapSphere(transform.position, 1.0f);

        // Itera a través de los enemigos golpeados y les causa daño
        foreach (Collider enemy in hitEnemies)
        {
            if (enemy.CompareTag("Enemy"))
            {
                // Accede al script de salud del enemigo y causa daño
                EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(attackDamage);
                }
            }
        }
    }
}
