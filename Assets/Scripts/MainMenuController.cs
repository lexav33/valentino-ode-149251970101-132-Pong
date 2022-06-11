using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Created By Valentino Ode - 149251970101-132 ");
        SceneManager.LoadScene("PlayerNameInput");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Valentino Ode - 149251970101-132 ");
    }
}
