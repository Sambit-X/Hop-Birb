using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    
    public void addScore(int addScore)
    {
        playerScore += addScore;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene("Main Game");
    }
    public void returnMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void exitGame()
    {
        Application.Quit();
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    private bool isFullscreen = true; // Flag to track the current state (fullscreen or windowed)


    private void Update()
    {
        // Check for the toggle input
        if (Input.GetKeyDown(KeyCode.F11))
        {
            // Toggle between fullscreen and windowed mode
            if (isFullscreen)
            {
                SetWindowedMode();
            }
            else
            {
                SetFullscreenMode();
            }
        }
    }

    private void SetFullscreenMode()
    {
        // Set the game to fullscreen mode
        Screen.fullScreen = true;
        isFullscreen = true;
    }

    private void SetWindowedMode()
    {
        // Set the game to windowed mode
        Screen.fullScreen = false;
        isFullscreen = false;
    }
}
