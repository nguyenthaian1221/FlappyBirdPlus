using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject winLevelPanel;
    void Start()
    {
        gameOver = false;
        CoinPicker.coin = 0;
        Time.timeScale = 1;


    }

    // Update is called once per frame
    void Update()
    {
      if (gameOver)
        {

            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

      if (CoinPicker.coin ==3)
        {

            Time.timeScale = 0;
            winLevelPanel.SetActive(true);
        }

    }
}
