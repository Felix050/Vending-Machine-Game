using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coin : MonoBehaviour
{
    public static event Action<int> CoinInCoinHole = delegate { };

    private int coinsValue;

    private bool mouseButtonReleased;

    // Start is called before the first frame update
    void Start()
    {
        coinsValue = Convert.ToInt32(name.Substring(name.IndexOf("_") + 1, 1));//irá pegar o valor da moeda Coin_5 <- ( o 5)
    }

    private void OnMouseDown()
    {
        mouseButtonReleased = false;
    }

    private void OnMouseUp()
    {
        mouseButtonReleased = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (mouseButtonReleased && collision.gameObject.name == "CoinHole")
        {
            CoinInCoinHole(coinsValue);
            Destroy(gameObject);
        }
    }
}
