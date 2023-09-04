using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel; // Panel de Game Over

    private void Start()
    {
        // Al principio, aseg�rate de que el panel de Game Over est� desactivado
        gameOverPanel.SetActive(false);
    }

    // Llamada cuando el jugador muere
    public void ShowGameOverMenu()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // Pausa el juego
    }

    // Funci�n para el bot�n "Retry" (Reintentar)
    public void Retry()
    {
        // Cargar la escena actual (esto reiniciar� la escena)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f; // Reanuda el juego
    }

    // Funci�n para el bot�n "Back to Main Menu" (Volver al Men� Principal)
    public void BackToMainMenu()
    {
        // Cargar la escena del men� principal (aseg�rate de configurar el nombre de la escena correctamente)
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f; // Reanuda el juego
    }
}
