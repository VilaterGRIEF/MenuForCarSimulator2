using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void GameMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
