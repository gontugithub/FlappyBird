using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    [SerializeField]private GameObject _gameOverGame;

    public int LifeCount { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        _gameOverGame.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ChangeSceneLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void ChangeSceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ChangeCredits()
    {
        SceneManager.LoadScene("Credits");
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IncrementLifeCount()
    {
        LifeCount++;
        Debug.Log($"LifeCount incrementado: {LifeCount}");

        if (LifeCount >= 3)
        {
            LifeCount = 0;
            Debug.Log("Mostrando anuncio...");
            FindObjectOfType<Interstitial>().ShowAd(); // Llama al AdManager para mostrar el anuncio
        }
    }

}
