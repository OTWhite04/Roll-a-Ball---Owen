using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Roll-a-Ball_Level_1_Owen");
    }

    public void ControlsMenu()
    {
        SceneManager.LoadScene("Controls_Menu");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

   
}
