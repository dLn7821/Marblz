using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathScene : MonoBehaviour
{
    public GameObject deathScene;

    public bool isDead;
    public void DiedScene()
    {
        Time.timeScale = 0f;
        deathScene.SetActive(true);
        isDead = true;
    }
    public void QuitGame()
    {
        DBManager.LogOut();
        Application.Quit();
    }
    public void GoToGame()
    {
        deathScene.SetActive(true);
        isDead = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }

}
