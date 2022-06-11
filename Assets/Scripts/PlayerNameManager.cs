using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerNameManager : MonoBehaviour
{
    public static PlayerNameManager pnm;
    public InputField inputField1;
    public InputField inputField2;

    public string player1_name;
    public string player2_name;

    private void Awake() 
    {
        if (pnm == null)
        {
            pnm = this;
            DontDestroyOnLoad(gameObject);
        }    
        else
        {
            Destroy(gameObject);
        }
    }


    public void SetPlayerName()
    {
        if(inputField1.text != null)
        {
            player1_name = inputField1.text;
        }
        else
        {
            player1_name = "Player 1";
        }
        
        if(inputField2.text != null)
        {
            player2_name = inputField2.text;
        }
        else
        {
            player2_name = "Player 2";
        }

        SceneManager.LoadScene("Game");
    }
}
