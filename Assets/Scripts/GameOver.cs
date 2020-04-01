using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
