using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("PlayScene1");
    }

    public void CreditsMenu()
    {
        SceneManager.LoadScene("CreditsMenu");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu2");
    }

    public void Beastman()
    { 
        SceneManager.LoadScene("Beastman");
    }

    public void Queen()
    {
        SceneManager.LoadScene("Queen");
    }

    public void Hero()
    {
        SceneManager.LoadScene("Hero");
    }


}        
