using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SmartCity()
    {
        SceneManager.LoadScene("SmartCity");
    }
    public void SmartHome()
    {
        SceneManager.LoadScene("SmartHome");
    }
    public void Menu()
    {
        SceneManager.LoadScene("UI");
    }
    public void doExitGame() 
    {
        Application.Quit();
    }
}
