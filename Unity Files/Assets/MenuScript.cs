using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Main Game");
    }
}
