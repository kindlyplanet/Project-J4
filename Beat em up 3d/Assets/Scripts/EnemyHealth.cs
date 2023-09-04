using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100; // La salud m�xima del enemigo
    private int currentHealth; // La salud actual del enemigo

    // Aqu� puedes agregar eventos o funciones para manejar la muerte del enemigo si lo deseas

    private void Start()
    {
        // Configura la salud inicial del enemigo
        currentHealth = maxHealth;
    }

    // Funci�n para recibir da�o
    public void TakeDamage(int damage)
    {
        // Resta el da�o a la salud actual del enemigo
        currentHealth -= damage;

        // Aqu� puedes agregar l�gica adicional, como efectos visuales o eventos cuando el enemigo recibe da�o

        // Verifica si el enemigo ha muerto
        if (currentHealth <= 0)
        {
            Die(); // Llama a la funci�n para manejar la muerte del enemigo
        }
    }

    // Funci�n para manejar la muerte del enemigo
    private void Die()
    {
        // Aqu� puedes agregar l�gica para manejar la muerte del enemigo, como desactivar el GameObject o reproducir una animaci�n de muerte
        // Puedes tambi�n notificar a otros scripts o sistemas que el enemigo ha muerto
        Destroy(gameObject); // Ejemplo: destruye el GameObject del enemigo
    }
}
