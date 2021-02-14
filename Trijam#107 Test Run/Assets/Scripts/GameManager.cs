using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject startMenu;
    public GameObject loseMenu;
    public GameObject winMenu;

    public GameObject player;

    private void Update()
    {
        if (Player.gameOver)
        {
            loseMenu.SetActive(true);
            startMenu.SetActive(false);
        }

        if (Player.gameWon)
        {
            winMenu.SetActive(true);
            startMenu.SetActive(false);
        }
    }

    public void PlayGame()
    {
        startMenu.SetActive(false);
        player.GetComponent<PlayerMovement>().canMove = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);

        Player.gameOver = false;
        Player.gameWon = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
