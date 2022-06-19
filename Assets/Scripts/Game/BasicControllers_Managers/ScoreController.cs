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

    private void Update()
    {
        skorKiri.text = manager.leftScore.ToString();
        skorKanan.text = manager.rightScore.ToString();
    }
}
