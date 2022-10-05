using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class VendingMachine : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI coinsSumText;

    [SerializeField]
    private GameObject doceabutton;

    [SerializeField]
    private GameObject docebbutton;

    [SerializeField]
    private GameObject docecbutton;

    [SerializeField]
    private GameObject docea;

    [SerializeField]
    private GameObject doceb;

    [SerializeField]
    private GameObject docec;

    [SerializeField]
    private GameObject coin_1;

    [SerializeField]
    private GameObject coin_1vp;

    [SerializeField]
    private GameObject coin_1vp1;

    [SerializeField]
    private GameObject coin_trocoa1;

    [SerializeField]
    private GameObject coin_trocoaA1;

    [SerializeField]
    private GameObject coin_2;

    [SerializeField]
    private GameObject coin_22;

    [SerializeField]
    private GameObject coin_222;

    [SerializeField]
    private GameObject coin_2vp;

    [SerializeField]
    private GameObject coin_2vp2;

    [SerializeField]
    private GameObject coin_trocoa2;

    [SerializeField]
    private GameObject coin_trocoaA2;

    [SerializeField]
    private GameObject coin_5;

    [SerializeField]
    private GameObject coin_55;

    [SerializeField]
    private GameObject coin_5vp;

    [SerializeField]
    private GameObject coin_trocoa5;

    private int coinsSumValue;

    private int auxliberar;

    private void Start()
    {
        Debug.Log("Starting VendingMachine");
        coinsSumText.text = "00";
        coinsSumValue = 0;
        Coin.CoinInCoinHole += AddCoinsValueAndCheckResult;
        docea.GetComponent<Collider2D>().enabled = false;
        doceb.GetComponent<Collider2D>().enabled = false;
        docec.GetComponent<Collider2D>().enabled = false;
        
        
    }

    private void AddCoinsValueAndCheckResult(int value)
    {
        coinsSumValue += value;
        coinsSumText.text = coinsSumValue.ToString();
}

    public void ReleaseDoceA(int value)
    {
        coinsSumValue += value;
        coinsSumText.text = coinsSumValue.ToString();

        if(coinsSumValue == 1)
        {
        coin_1vp.transform.position = new Vector2(coin_1vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 2)
        {
        coin_2vp.transform.position = new Vector2(coin_2vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 3)
        {
        coin_2vp.transform.position = new Vector2(coin_2vp.transform.position.x, -1.5f);
        coin_1vp.transform.position = new Vector2(coin_1vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 4)
        {
        coin_2vp.transform.position = new Vector2(coin_2vp.transform.position.x, -1.5f);
        coin_2vp2.transform.position = new Vector2(coin_2vp2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 5)
        {
        coin_5vp.transform.position = new Vector2(coin_5vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }

        if(coinsSumValue == 6)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 7)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_trocoa1.transform.position = new Vector2(coin_trocoa1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 8)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_trocoa2.transform.position = new Vector2(coin_trocoa2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 9)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_trocoaA1.transform.position = new Vector2(coin_trocoaA1.transform.position.x, -1.5f);
        coin_trocoa2.transform.position = new Vector2(coin_trocoa2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 10)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_trocoa2.transform.position = new Vector2(coin_trocoa2.transform.position.x, -1.5f);
        coin_trocoaA2.transform.position = new Vector2(coin_trocoaA2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 11)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 12)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_trocoa1.transform.position = new Vector2(coin_trocoa1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 13)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_trocoa2.transform.position = new Vector2(coin_trocoa2.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 14)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_trocoa2.transform.position = new Vector2(coin_trocoa2.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_trocoa1.transform.position = new Vector2(coin_trocoa1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 15)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_trocoa2.transform.position = new Vector2(coin_trocoa2.transform.position.x, -1.5f);
        coin_trocoaA2.transform.position = new Vector2(coin_trocoaA2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 16)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_55.transform.position = new Vector2(coin_55.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 17)
        {
        docea.GetComponent<Collider2D>().enabled = true;
        docea.transform.position = new Vector2(docea.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_55.transform.position = new Vector2(coin_55.transform.position.x, -1.5f);
        coin_trocoaA1.transform.position = new Vector2(coin_trocoaA1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }

    }

    public void ReleaseDoceB(int value)
    {
        
        coinsSumValue += value;
        coinsSumText.text = coinsSumValue.ToString();

        if(coinsSumValue == 1)
        {
        coin_1vp.transform.position = new Vector2(coin_1vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 2)
        {
        coin_2vp.transform.position = new Vector2(coin_2vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 3)
        {
        coin_2vp.transform.position = new Vector2(coin_2vp.transform.position.x, -1.5f);
        coin_1vp.transform.position = new Vector2(coin_1vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 4)
        {
        coin_2vp.transform.position = new Vector2(coin_2vp.transform.position.x, -1.5f);
        coin_2vp2.transform.position = new Vector2(coin_2vp2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 5)
        {
        coin_5vp.transform.position = new Vector2(coin_5vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 6)
        {
        coin_5vp.transform.position = new Vector2(coin_5vp.transform.position.x, -1.5f);
        coin_1vp.transform.position = new Vector2(coin_1vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }

        if(coinsSumValue == 7)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 8)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_1.transform.position = new Vector2(coin_1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 9)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 10)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_1.transform.position = new Vector2(coin_1.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 11)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_22.transform.position = new Vector2(coin_22.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 12)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 13)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_1.transform.position = new Vector2(coin_1.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 14)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 15)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coin_1.transform.position = new Vector2(coin_1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 16)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coin_22.transform.position = new Vector2(coin_22.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 17)
        {
        doceb.GetComponent<Collider2D>().enabled = true;
        doceb.transform.position = new Vector2(doceb.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_55.transform.position = new Vector2(coin_55.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
    }

    public void ReleaseDoceC(int value)
    {
        coinsSumValue += value;
        coinsSumText.text = coinsSumValue.ToString();

        if(coinsSumValue == 1)
        {
        coin_1vp.transform.position = new Vector2(coin_1vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 2)
        {
        coin_2vp.transform.position = new Vector2(coin_2vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 3)
        {
        coin_2vp.transform.position = new Vector2(coin_2vp.transform.position.x, -1.5f);
        coin_1vp.transform.position = new Vector2(coin_1vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 4)
        {
        coin_2vp.transform.position = new Vector2(coin_2vp.transform.position.x, -1.5f);
        coin_2vp2.transform.position = new Vector2(coin_2vp2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 5)
        {
        coin_5vp.transform.position = new Vector2(coin_5vp.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 6)
        {
        coin_5vp.transform.position = new Vector2(coin_5vp.transform.position.x, -1.5f);
        coin_1vp1.transform.position = new Vector2(coin_1vp1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 7)
        {
        coin_5vp.transform.position = new Vector2(coin_5vp.transform.position.x, -1.5f);
        coin_2vp2.transform.position = new Vector2(coin_2vp2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 8)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 9)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coin_1.transform.position = new Vector2(coin_1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 10)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 11)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coin_1.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 12)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coin_22.transform.position = new Vector2(coin_22.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 13)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 14)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_1.transform.position = new Vector2(coin_1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 15)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 16)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_1.transform.position = new Vector2(coin_1.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
        if(coinsSumValue == 17)
        {
        docec.GetComponent<Collider2D>().enabled = true;
        docec.transform.position = new Vector2(docec.transform.position.x, -1.5f);
        coin_2.transform.position = new Vector2(coin_2.transform.position.x, -1.5f);
        coin_5.transform.position = new Vector2(coin_5.transform.position.x, -1.5f);
        coin_22.transform.position = new Vector2(coin_22.transform.position.x, -1.5f);
        coinsSumText.text = "00";
        coinsSumValue = 0;
        }
    }



    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnDestroy()
    {
        Coin.CoinInCoinHole -= AddCoinsValueAndCheckResult;
    }

}
