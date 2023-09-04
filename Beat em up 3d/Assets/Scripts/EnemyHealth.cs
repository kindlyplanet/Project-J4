using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100; // La salud máxima del enemigo
    private int currentHealth; // La salud actual del enemigo

    // Aquí puedes agregar eventos o funciones para manejar la muerte del enemigo si lo deseas

    private void Start()
    {
        // Configura la salud inicial del enemigo
        currentHealth = maxHealth;
    }

    // Función para recibir daño
    public void TakeDamage(int damage)
    {
        // Resta el daño a la salud actual del enemigo
        currentHealth -= damage;

        // Aquí puedes agregar lógica adicional, como efectos visuales o eventos cuando el enemigo recibe daño

        // Verifica si el enemigo ha muerto
        if (currentHealth <= 0)
        {
            Die(); // Llama a la función para manejar la muerte del enemigo
        }
    }

    // Función para manejar la muerte del enemigo
    private void Die()
    {
        // Aquí puedes agregar lógica para manejar la muerte del enemigo, como desactivar el GameObject o reproducir una animación de muerte
        // Puedes también notificar a otros scripts o sistemas que el enemigo ha muerto
        Destroy(gameObject); // Ejemplo: destruye el GameObject del enemigo
    }
}
