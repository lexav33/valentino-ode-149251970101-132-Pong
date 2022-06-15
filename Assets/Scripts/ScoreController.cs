using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorKiri;
    public Text skorKanan;

    public ScoreManager manager;

    public Text namaKiri;
    public Text namaKanan;
 
    // void Start()
    // {
    //     namaKiri.text = "Player 1";
    //     namaKanan.text = "Player 2";
    //     if(PlayerNameManager.pnm.player1_name != null)
    //     {
    //     namaKiri.text = PlayerNameManager.pnm.player1_name;
    //     }
    //     namaKanan.text = PlayerNameManager.pnm.player2_name;
    // }

    void Update()
    {
        skorKiri.text = manager.leftScore.ToString();
        skorKanan.text = manager.rightScore.ToString();
    }
}
