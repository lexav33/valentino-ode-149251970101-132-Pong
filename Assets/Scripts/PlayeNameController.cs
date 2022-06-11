using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayeNameController : MonoBehaviour
{
    public void Go()
    {
        SceneManager.LoadScene("Game");
    }
}
