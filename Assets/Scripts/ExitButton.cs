using UnityEngine;

public class ExitButtonScript : MonoBehaviour
{
    // M�todo que se llamar� al presionar el bot�n
    public void ExitGame()
    {
        // Imprime un mensaje en la consola para comprobar que se llama al m�todo (opcional)
        Debug.Log("Saliendo del juego...");

        // Salir del juego en una aplicaci�n compilada
        Application.Quit();

        // Si est�s en el editor de Unity, detiene el modo de juego
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
