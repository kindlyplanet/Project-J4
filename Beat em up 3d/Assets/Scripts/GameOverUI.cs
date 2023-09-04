using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel; // Panel de Game Over

    private void Start()
    {
        // Al principio, asegúrate de que el panel de Game Over esté desactivado
        gameOverPanel.SetActive(false);
    }

    // Llamada cuando el jugador muere
    public void ShowGameOverMenu()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // Pausa el juego
    }

    // Función para el botón "Retry" (Reintentar)
    public void Retry()
    {
        // Cargar la escena actual (esto reiniciará la escena)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f; // Reanuda el juego
    }

    // Función para el botón "Back to Main Menu" (Volver al Menú Principal)
    public void BackToMainMenu()
    {
        // Cargar la escena del menú principal (asegúrate de configurar el nombre de la escena correctamente)
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f; // Reanuda el juego
    }
}
