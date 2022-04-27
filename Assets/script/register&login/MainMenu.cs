using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MainMenu : MonoBehaviour
{
    public TMP_Text playerDisplay;
    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay.SetText("Logged in as: " + DBManager.username, true);
        }
    }
    public void GoToRegister()
    {
        SceneManager.LoadScene(1);

    }
    public void GoToLogin()
    {
        SceneManager.LoadScene(2);

    }
    public void GoToGame()
    {
        SceneManager.LoadScene(3);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        DBManager.LogOut();
        Application.Quit();
    }
}
