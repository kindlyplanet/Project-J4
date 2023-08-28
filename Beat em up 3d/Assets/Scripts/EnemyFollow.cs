using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float followDistance = 10.0f; // Distancia mínima para seguir al jugador
    private Transform target; // Referencia al jugador encontrado

    private void Start()
    {
        FindPlayer();
    }

    private void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;

            // Comprobar si el jugador está a una distancia válida para seguir
            if (direction.magnitude <= followDistance)
            {
                direction.Normalize();

                // Rotar el enemigo para mirar hacia el jugador
                transform.LookAt(target);

                // Mover el enemigo en la dirección del jugador
                transform.position += direction * moveSpeed * Time.deltaTime;
            }
        }
    }

    private void FindPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
    }
}
