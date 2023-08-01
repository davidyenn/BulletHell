using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("BossFight");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
