using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform respawnPoint; // Referencia al punto de respawn

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Colisión con el jugador, realiza el respawn
            RespawnPlayer(other.transform);
        }
    }

    private void RespawnPlayer(Transform playerTransform)
    {
        playerTransform.position = respawnPoint.position;
        playerTransform.rotation = respawnPoint.rotation;

        // Puedes realizar otras acciones aquí, como reiniciar la vida o el estado del jugador.
    }
}
