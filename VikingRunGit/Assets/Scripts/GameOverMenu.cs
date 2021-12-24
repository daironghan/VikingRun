using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txtScore;
    public Text txtCoins;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Setup()
    {
        gameObject.SetActive(true);
        txtCoins.text = "Coins: " + GameManager.inst.coin;
    }
}
