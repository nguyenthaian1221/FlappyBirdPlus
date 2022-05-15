using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    public static float coin = 0;
    public TextMeshProUGUI textCoins;
    // Ket noi Bird voi Coin bang OnTriggerEnter2D
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Coins")
        {
            coin++;
            textCoins.text = coin.ToString() + "/3";
            Destroy(other.gameObject);
        }
    }
}
