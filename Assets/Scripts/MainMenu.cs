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

    public void GoToLevel1()
    {
        SceneManager.LoadScene("Roll-a-Ball_Level_1_Owen");
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Roll-a-Ball_Level_2_Owen");
    }

    public void ControlsMenu()
    {
        SceneManager.LoadScene("Controls_Menu");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level_Select");
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
