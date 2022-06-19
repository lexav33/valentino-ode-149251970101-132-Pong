using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditController : MonoBehaviour
{
    public void BackToMain(){
        SceneManager.LoadScene("Main Menu");
    }

    public void OpenURL(){
        Application.OpenURL("https://github.com/lexav33");
    }
}
