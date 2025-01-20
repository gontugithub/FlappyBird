using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    [SerializeField]private GameObject _gameOverGame;

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

}
