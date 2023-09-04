using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float attackRange = 2.0f;

    private Transform target; // Referencia al jugador encontrado
    private bool isAttacking = false;

    private void Start()
    {
        // Busca al jugador al comienzo y configura la referencia 'target'
        FindPlayer();
    }

    private void Update()
    {
        if (target != null && !isAttacking)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, target.position);

            if (distanceToPlayer <= attackRange)
            {
                Attack();
            }
            else
            {
                Chase();
            }
        }
    }

    private void Chase()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;

            transform.Translate(direction * moveSpeed * Time.deltaTime);

            transform.LookAt(target.position);
        }
    }

    private void Attack()
    {
        isAttacking = true;
    }

    private void EndAttack()
    {
        isAttacking = false;
    }

    private void FindPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
        else
        {
            Debug.LogError("No se pudo encontrar al jugador. Asegúrate de que el jugador tenga el tag 'Player'.");
        }
    }
}
