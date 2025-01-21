using UnityEngine;

public class ExitButtonScript : MonoBehaviour
{
    // Método que se llamará al presionar el botón
    public void ExitGame()
    {
        // Imprime un mensaje en la consola para comprobar que se llama al método (opcional)
        Debug.Log("Saliendo del juego...");

        // Salir del juego en una aplicación compilada
        Application.Quit();

        // Si estás en el editor de Unity, detiene el modo de juego
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
